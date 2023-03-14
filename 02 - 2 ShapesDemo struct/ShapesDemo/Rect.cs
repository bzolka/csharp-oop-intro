namespace ShapesDemo;

public struct Rect
{
    public int x;
    public int y;
    public int w;
    public int h;

    public double GetArea() { return w * h; }

    public void PrintName() { Console.Write("Rect"); }

    public void PrintParams()
    {
        // Szebb és hatékonyabb lenne a sztring interpoláció!
        Console.WriteLine(" x: " + x.ToString() + ", y: " + y.ToString()
             + ", w: " + w.ToString() + ", h: " + h.ToString());
    }

    public void Print()
    {
        PrintName();
        PrintParams();
        Console.WriteLine(" Area: " + GetArea());
    }

}
