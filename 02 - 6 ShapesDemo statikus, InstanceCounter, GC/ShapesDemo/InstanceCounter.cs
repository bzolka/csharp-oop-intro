namespace ShapesDemo;

class InstaceCounter
{
    static int count = 0;

    public InstaceCounter() { count++; }

    ~InstaceCounter() { count--; }

    public static int Count
    {
        get { return count; }
    }
}
