public class Square : Shape
{
    public Square(IColor color) : base(color) { }

    public override string Draw()
    {
        return $"Quadrado preenchido com {color.ApplyColor()}";
    }
}