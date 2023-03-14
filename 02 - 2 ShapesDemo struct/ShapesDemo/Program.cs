namespace ShapesDemo;

class Program
{
    static void Main(string[] args)
    {
        Rect r1;
        r1.x = 5;
        r1.y = 5;
        r1.w = 10;
        r1.h = 20;
        r1.Print();

        Circle c1;
        c1.x = 10;
        c1.y = 2;
        c1.r = 3;
        c1.Print();

        Console.ReadKey();
    }
}
