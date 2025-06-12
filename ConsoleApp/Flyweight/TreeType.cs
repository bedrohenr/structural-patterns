public class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Desenhando árvore do tipo {Name} (Cor: {Color}, Textura: {Texture}) " +
                          $"na posição ({x}, {y})");
    }
}