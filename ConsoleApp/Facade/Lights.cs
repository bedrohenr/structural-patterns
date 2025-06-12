// Subsistema: Iluminação
public class Lights
{
    public void Dim(int percent) => Console.WriteLine($"Luzes ajustadas para {percent}%");
    public void On() => Console.WriteLine("Luzes ligadas");
    public void Off() => Console.WriteLine("Luzes desligadas");
}