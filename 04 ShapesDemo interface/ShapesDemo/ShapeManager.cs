namespace ShapesDemo;

public class ShapeManager
{
    List<Shape> shapes = new List<Shape>();

    public void AddShape(Shape shape)
    {
        shapes.Add(shape);
    }

    public void PrintShapes()
    {
        for (int i = 0; i < shapes.Count; ++i)
            shapes[i].Print();
    }

    public void SortShapes()
    {
        // A List<T> beépített sorrendezését használjuk
        shapes.Sort();
    }
}
