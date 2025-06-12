public class Menu : IMenuComponent
{
    private readonly string _name;
    private readonly string _description;
    private readonly List<IMenuComponent> _children = new List<IMenuComponent>();

    public Menu(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Display(int depth = 0)
    {
        string indent = new string(' ', depth * 4);
        Console.WriteLine($"{indent}┌ {_name}");
        Console.WriteLine($"{indent}│ {_description}");
        Console.WriteLine($"{indent}├{new string('─', 30)}");

        foreach (var component in _children)
        {
            component.Display(depth + 1);
        }
    }

    public void Add(IMenuComponent component)
    {
        _children.Add(component);
    }
}