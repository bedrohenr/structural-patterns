public class RealImage : IImage
{
    private readonly string _filename;

    public RealImage(string filename)
    {
        _filename = filename;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"Carregando imagem pesada: {_filename}");
        // Simulação de carregamento demorado
        Thread.Sleep(1000);
    }

    public void Display()
    {
        Console.WriteLine($"Exibindo imagem: {_filename}\n");
    }
}