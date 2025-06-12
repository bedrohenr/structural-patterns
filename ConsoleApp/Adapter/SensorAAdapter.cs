public class SensorAAdapter : ITemperatureSensor
{
    private SensorA _sensor;

    public SensorAAdapter(SensorA sensor)
    {
        _sensor = sensor;
    }

    public double ReadTemperature()
    {
        return _sensor.GetTemperatureInCelsius();
    }
}