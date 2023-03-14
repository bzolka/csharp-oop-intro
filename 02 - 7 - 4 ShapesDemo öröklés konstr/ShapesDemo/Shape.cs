namespace ShapesDemo;

public abstract class Shape
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

    public virtual void Print()
    {
        PrintName();
        PrintParams();
        Console.WriteLine(" Area: " + GetArea());
    }

    // Probléma 1 megoldása
    public virtual void PrintName() { Console.Write("Shape"); }
    public virtual void PrintParams() { }
    public abstract double GetArea();

    public Shape(int x, int y)
    {
        X = x;
        Y = y;
    }
}
