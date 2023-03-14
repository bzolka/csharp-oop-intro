namespace ShapesDemo;

public class Circle
{
    private int x;
    private int y;
    private int r;

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

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
        Console.WriteLine($" x: {x} y: {y}, r: {r}");

    }

    public void Print()
    {
        PrintName();
        PrintParams();
        Console.WriteLine(" Area: " + GetArea());
    }

    public Circle(int x, int y, int r)
    {
        this.x = x;
        this.y = y;
        this.r = r;
    }
}
