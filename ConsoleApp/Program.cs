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

    static void Main()
    {
        Program p = new Program();

        // p.Adapter();
        p.Bridge();
    }
}