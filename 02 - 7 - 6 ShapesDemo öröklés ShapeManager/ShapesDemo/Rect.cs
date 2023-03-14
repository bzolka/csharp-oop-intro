namespace ShapesDemo;

public class Rect: Shape
{
    private int w;
    private int h;

    public int W
    {
        get { return w; }
        set
        {
            if (value < 0)
                throw new ArgumentNullException("value");
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

    public override double GetArea() { return w * h; }

    public override void PrintName() { Console.Write("Rect"); }

    public override void PrintParams()
    {
        // Előbb kiírjuk az ős paramétereit (x, y)
        base.PrintParams();
        // Majd a sajátainkat
        Console.WriteLine($", w: {w}, h: {h}");
    }

    public Rect(int x, int y, int w, int h): base(x, y)
    {
        this.W = w;
        this.H = h;
    }

}
