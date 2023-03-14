namespace ShapesDemo;

class Program
{
    static void Main(string[] args)
    {
        Rect r1; // (*1)
        r1 = new Rect(5, 5, 10, 20);
        r1.Print();

        Circle c1 = new Circle(10, 2, 3);
        //c1.r = -10;
        //c1.SetR(-10);
        c1.Print();

        Console.ReadKey();
    }
}
