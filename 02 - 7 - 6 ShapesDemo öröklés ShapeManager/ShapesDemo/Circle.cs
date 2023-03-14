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
        // Előbb kiírjuk az ős paramétereit (x, y)
        base.PrintParams();
        // Majd a sajátainkat
        Console.WriteLine($", r: {r}");
    }

    public Circle(int x, int y, int r): base(x, y)
    {
        this.R = r;
    }
}
