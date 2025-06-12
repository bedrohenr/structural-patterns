// Subsistema: Projetor
public class Projector
{
    public void On() => Console.WriteLine("Projetor ligado");
    public void Off() => Console.WriteLine("Projetor desligado");
    public void SetInput(string input) => Console.WriteLine($"Projetor configurado para: {input}");
    public void SetWideScreen() => Console.WriteLine("Modo widescreen ativado");
}
