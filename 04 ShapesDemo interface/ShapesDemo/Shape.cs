namespace ShapesDemo;

public abstract class Shape: IComparable
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
    public virtual void PrintParams()
    {
        Console.Write($" x: {x}, y: {y}");
    }

    public abstract double GetArea();

    public Shape(int x, int y)
    {
        X = x;
        Y = y;
    }

    #region IComparable Members

    public int CompareTo(object other)
    {
        return this.GetArea().CompareTo(((Shape)other).GetArea());
    }

    #endregion
}
