namespace ShapesDemo;

public class Rect
{
    public int x;
    public int y;
    public int w;
    public int h;

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
