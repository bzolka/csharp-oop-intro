namespace ShapesDemo;

class Program
{
    static void Main(string[] args)
    {
        ShapeManager sm = new ShapeManager();
        sm.AddShape(new Rect(10, 10, 20, 20));
        sm.AddShape(new Circle(1, 2, 3));
        sm.AddShape(new Circle(3, 4, 6));
        sm.SortShapes();
        sm.PrintShapes();
        Console.ReadKey();
    }
}
