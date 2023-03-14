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

    public double GetArea() { return r * r * 3.14; }

    public void PrintName() { Console.Write("Circle"); }

    public void PrintParams()
    {
        Console.WriteLine($" x: {X} y: {Y}, r: {r}");
    }

    public Circle(int x, int y, int r)
    {
        this.x = x;
        this.y = y;
        this.r = r;
    }
}
