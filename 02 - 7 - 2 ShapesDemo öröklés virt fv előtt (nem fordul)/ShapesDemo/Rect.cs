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

    public double GetArea() { return w * h; }

    public void PrintName() { Console.Write("Rect"); }

    public void PrintParams()
    {
        Console.WriteLine($" x: {X.ToString()}, y: {Y.ToString()}, w: {W.ToString()}, h: {H.ToString()}");
    }

    public Rect(int x, int y, int w, int h)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
    }

}
