public class HomeTheaterFacade
{
    private readonly DvdPlayer _dvd;
    private readonly Projector _projector;
    private readonly SoundSystem _sound;
    private readonly Lights _lights;

    public HomeTheaterFacade(DvdPlayer dvd, Projector projector, SoundSystem sound, Lights lights)
    {
        _dvd = dvd;
        _projector = projector;
        _sound = sound;
        _lights = lights;
    }

    public void PlayMovie(string movie)
    {
        Console.WriteLine("\nPreparando para assistir filme...");
        
        _lights.Dim(10);
        _projector.On();
        _projector.SetInput("DVD");
        _projector.SetWideScreen();
        _sound.On();
        _sound.SetSurroundSound();
        _sound.SetVolume(25);
        _dvd.On();
        _dvd.Play(movie);
        
        Console.WriteLine("Aproveite seu filme!\n");
    }

    public void EndMovie()
    {
        Console.WriteLine("\nEncerrando sessão de cinema...");
        
        _dvd.Stop();
        _dvd.Eject();
        _dvd.Off();
        _sound.Off();
        _projector.Off();
        _lights.On();
        
        Console.WriteLine("Sessão encerrada. Luzes normais.\n");
    }
}