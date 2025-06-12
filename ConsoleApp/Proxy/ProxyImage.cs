public class ProxyImage : IImage
{
    private RealImage _realImage;
    private readonly string _filename;

    public ProxyImage(string filename)
    {
        _filename = filename;
        Console.WriteLine($"Proxy criado para {_filename} (imagem ainda não carregada)");
    }

    public void Display()
    {
        // Carregamento lazy (somente quando necessário)
        if (_realImage == null)
        {
            _realImage = new RealImage(_filename);
        }
        _realImage.Display();
    }
}