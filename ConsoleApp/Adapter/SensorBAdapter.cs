public class SensorBAdapter : ITemperatureSensor
{
    private SensorB _sensor;

    public SensorBAdapter(SensorB sensor)
    {
        _sensor = sensor;
    }

    public double ReadTemperature()
    {
        return _sensor.ObtenerTemperaturaEnCentigrados();
    }
}
