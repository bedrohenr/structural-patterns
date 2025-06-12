public class SensorCAdapter : ITemperatureSensor
{
    private SensorC _sensor;

    public SensorCAdapter(SensorC sensor)
    {
        _sensor = sensor;
    }

    public double ReadTemperature()
    {
        return _sensor.FetchTempC();
    }
}