namespace ShapesDemo;

public class Shape
{
    private int x;
    private int y;

    public int X
    {
        get { return x; }
        set
        {
            if (value < 0)
                throw new ArgumentNullException("value");
            x = value;
        }
    }

    public int Y
    {
        get { return y; }
        set
        {
            if (value < 0)
                throw new ArgumentNullException("value");
            y = value;
        }
    }

    public void Print()
    {
        PrintName();
        PrintParams();
        Console.WriteLine(" Area: " + GetArea());
    }

    // Probléma 1 megoldása
    public void PrintName() { Console.Write("Shape"); }
    public void PrintParams() { }
    public double GetArea() { return 0; }
}
