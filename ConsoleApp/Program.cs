class Program
{
    public void Adapter()
    {
        var sensorA = new SensorA();
        var sensorB = new SensorB();
        var sensorC = new SensorC();

        // Criando adaptadores
        ITemperatureSensor adapterA = new SensorAAdapter(sensorA);
        ITemperatureSensor adapterB = new SensorBAdapter(sensorB);
        ITemperatureSensor adapterC = new SensorCAdapter(sensorC);

        // Usando os sensores de forma unificada
        Console.WriteLine("Temperatura Sensor A: " + adapterA.ReadTemperature() + "°C");
        Console.WriteLine("Temperatura Sensor B: " + adapterB.ReadTemperature() + "°C");
        Console.WriteLine("Temperatura Sensor C: " + adapterC.ReadTemperature() + "°C");

        // Sistema pode tratar todos os sensores igualmente
        var sensors = new List<ITemperatureSensor> { adapterA, adapterB, adapterC };
        
        foreach (var sensor in sensors)
        {
            Console.WriteLine($"Leitura unificada: {sensor.ReadTemperature()}°C");
        }
    }

    public void Bridge()
    {
        IColor vermelho = new RedColor();
        IColor azul = new BlueColor();

        // Criando diferentes combinações de formas e cores
        Shape circuloVermelho = new Circle(vermelho);
        Shape circuloAzul = new Circle(azul);
        Shape quadradoVermelho = new Square(vermelho);
        Shape quadradoAzul = new Square(azul);

        // Usando as combinações
        Console.WriteLine(circuloVermelho.Draw());
        Console.WriteLine(circuloAzul.Draw());
        Console.WriteLine(quadradoVermelho.Draw());
        Console.WriteLine(quadradoAzul.Draw());

        // Demonstração de extensibilidade
        IColor novaCor = new GreenColor(); // Nova implementação
        Shape novoQuadrado = new Square(novaCor);
        Console.WriteLine(novoQuadrado.Draw());
    }

    public void Composite()
    {
        var mainMenu = new Menu("Menu Principal", "Cardápio completo do restaurante");
        
        // Criando seção de entradas
        var appetizers = new Menu("Entradas", "Aperitivos e porções");
        appetizers.Add(new MenuItem("Bruschetta", "Tomate, manjericão e alho em pão italiano", 18.90));
        appetizers.Add(new MenuItem("Camarão Empanado", "Camarões empanados com molho tártaro", 32.50));
        
        // Criando seção de pratos principais
        var mainCourses = new Menu("Pratos Principais", "Refeições completas");
        
        var meats = new Menu("Carnes", "Cortes selecionados");
        meats.Add(new MenuItem("Filé Mignon", "250g com batatas rústicas", 68.90));
        meats.Add(new MenuItem("Picanha", "300g com farofa e vinagrete", 62.75));
        
        var pastas = new Menu("Massas", "Massas artesanais");
        pastas.Add(new MenuItem("Carbonara", "Bacon, ovos e queijo pecorino", 45.80));
        pastas.Add(new MenuItem("Bolonhesa", "Molho de carne moída com tomate", 42.30));
        
        mainCourses.Add(meats);
        mainCourses.Add(pastas);
        
        // Criando seção de sobremesas
        var desserts = new Menu("Sobremesas", "Doces e sobremesas");
        desserts.Add(new MenuItem("Cheesecake", "Com calda de frutas vermelhas", 22.40));
        desserts.Add(new MenuItem("Tiramisù", "Clássico italiano", 24.90));
        
        // Montando menu completo
        mainMenu.Add(appetizers);
        mainMenu.Add(mainCourses);
        mainMenu.Add(desserts);
        
        // Exibindo toda a estrutura de menus
        mainMenu.Display();
    }

    public void Decorator()
    {
        // Cenário 1: Notificação única via Email
        INotification emailNotifier = new EmailDecorator(new BaseNotification());
        emailNotifier.Send("Relatório diário disponível");
        
        Console.WriteLine("\n---\n");
        
        // Cenário 2: Combinação de Email e SMS
        INotification emailSmsNotifier = new SMSDecorator(
                                new EmailDecorator(
                                new BaseNotification()));
        emailSmsNotifier.Send("Alerta de segurança: login detectado");
        
        Console.WriteLine("\n---\n");
        
        // Cenário 3: Notificação completa (Email + SMS + Push)
        INotification fullNotifier = new PushDecorator(
                             new SMSDecorator(
                             new EmailDecorator(
                             new BaseNotification())));
        fullNotifier.Send("Promoção especial: 50% de desconto!");

    }
    static void Main()
    {
        Program p = new Program();

        // p.Adapter();
        // p.Bridge();
        // p.Composite();
        p.Decorator();
    }
}