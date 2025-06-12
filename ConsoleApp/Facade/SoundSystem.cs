// Subsistema: Sistema de Som
public class SoundSystem
{
    public void On() => Console.WriteLine("Sistema de som ligado");
    public void Off() => Console.WriteLine("Sistema de som desligado");
    public void SetVolume(int level) => Console.WriteLine($"Volume ajustado para {level}");
    public void SetSurroundSound() => Console.WriteLine("Som surround ativado");
}
