// Subsistema: DVD Player
public class DvdPlayer
{
    public void On() => Console.WriteLine("DVD Player ligado");
    public void Off() => Console.WriteLine("DVD Player desligado");
    public void Play(string movie) => Console.WriteLine($"Reproduzindo filme: {movie}");
    public void Stop() => Console.WriteLine("DVD parado");
    public void Eject() => Console.WriteLine("DVD ejetado");
}