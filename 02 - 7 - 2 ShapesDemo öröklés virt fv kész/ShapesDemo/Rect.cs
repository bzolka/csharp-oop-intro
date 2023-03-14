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
        Console.WriteLine($" x: {X}, y: {Y}, w: {W}, h: {H}");
    }

    public Rect(int x, int y, int w, int h)
    {
        this.X = x;
        this.Y = y;
        this.W = w;
        this.H = h;
    }

}
