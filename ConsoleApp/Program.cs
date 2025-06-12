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
    static void Main()
    {
        Program p = new Program();

        p.Adapter();
    }
}