public interface IMenuComponent
{
    void Display(int depth = 0);
    void Add(IMenuComponent component);
}