public class MenuItem : IMenuComponent
{
    private readonly string _name;
    private readonly string _description;
    private readonly double _price;

    public MenuItem(string name, string description, double price)
    {
        _name = name;
        _description = description;
        _price = price;
    }

    public void Display(int depth = 0)
    {
        string indent = new string(' ', depth * 4);
        Console.WriteLine($"{indent}→ {_name} - R${_price:F2}");
        Console.WriteLine($"{indent}  {_description}\n");
    }

    public void Add(IMenuComponent component)
    {
        throw new NotSupportedException("Não é possível adicionar itens a um MenuItem");
    }
}