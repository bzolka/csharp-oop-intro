namespace ShapesDemo;

public class Circle: Shape
{
    private int r;

    public int R
    {
        get { return r; }
        set
        {
            if (value < 0)
                throw new ArgumentNullException("value");
            r = value;
        }
    }

    public override double GetArea() { return r * r * 3.14; }

    public override void PrintName() { Console.Write("Circle"); }

    public override void PrintParams()
    {
        Console.WriteLine($" x: {X} y: {Y}, r: {r}");
    }

    public Circle(int x, int y, int r)
    {
        this.X = x;
        this.Y = y;
        this.R = r;
    }
}
