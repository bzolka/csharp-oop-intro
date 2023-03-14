namespace ShapesDemo;

public class Rect
{
    private int x;
    private int y;
    private int w;
    private int h;

    public int GetW()
    {
        return w;
    }

    public void SetW(int value)
    {
        if (value < 0)
            throw new ArgumentNullException("value");
        w = value;
    }

    public int GetH()
    {
        return h;
    }

    public void SetH(int value)
    {
        if (value < 0)
            throw new ArgumentNullException("value");
        h = value;
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
