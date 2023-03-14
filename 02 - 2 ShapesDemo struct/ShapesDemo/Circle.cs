namespace ShapesDemo;

public struct Circle
{
    public int x;
    public int y;
    public int r;

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

}
