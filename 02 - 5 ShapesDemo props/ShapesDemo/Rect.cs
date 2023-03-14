namespace ShapesDemo;

public class Rect
{
    private int x;
    private int y;
    private int w;
    private int h;

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

    public int W
    {
        get { return w; }
        set
        {
            if (value < 0)
                throw new ArgumentException("value");
		        w = value;
        }
    }

    public int H
    {
        get { return h; }
        set
        {
            if (value < 0)
                throw new ArgumentNullException("value");
		    h = value;
        }
    }

    public double GetArea() { return w * h; }

    public void PrintName() { Console.Write("Rect"); }

    public void PrintParams()
    {
        Console.WriteLine($" x: {x}, y: {y}, w: {w}, h: {h}");
    }

    public void Print()
    {
        PrintName();
        PrintParams();
        Console.WriteLine(" Area: " + GetArea());
    }

    public Rect(int x, int y, int w, int h)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
    }

}
