using System.Collections;

namespace ShapesDemo;

public class ShapeManager
{
    ArrayList shapes = new ArrayList();

    public void AddShape(Shape shape)
    {
        shapes.Add(shape); // Shape -> object aut konv.
    }

    public void PrintShapes()
    {
        object o;
        for (int i = 0; i < shapes.Count; ++i)
        {
            o = shapes[i];
            ((Shape)o).Print();
        }
    }
}
