public class Circle : Shape
{
    public Circle(IColor color) : base(color) { }

    public override string Draw()
    {
        return $"Círculo preenchido com {color.ApplyColor()}";
    }
}