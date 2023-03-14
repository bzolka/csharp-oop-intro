namespace ShapesDemo;

class Program
{
    static void Main(string[] args)
    {

        // Behelyettesíthetőség
        Shape s = new Rect(10, 20, 10, 10);
        Rect r2 = (Rect)s; // Explicit cast, ok
        //Circle c21 = (Circle)s; // Explicit cast, InvalidCastException

        // "is" operátor
        Shape s3 = new Rect(10, 20, 10, 10);
        if (s3 is Rect)
        {
            Rect r = (Rect)s3; // Explicit cast, biztos OK, hiszen ellenőriztük
            // ...
        }

        // "as" operátor
        Shape s4 = new Rect(10, 20, 10, 10);
        Rect r4 = s4 as Rect;
        if (r4 != null)
        {
            //...
        }

        ShapeManager sm = new ShapeManager();
        Rect r1 = new Rect(10, 10, 20, 20);
        sm.AddShape(r1); // aut. Rect -> Shape konv
        sm.AddShape(new Circle(1, 2, 3));
        sm.AddShape(new Circle(3, 4, 6));
        sm.PrintShapes();

        Console.ReadKey();
    }
}
