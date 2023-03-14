namespace ShapesDemo;

public class Sorter
{
    public static void Sort(List<IComparable> items)
    {
        for (int i = 1; i < items.Count; i++)
        {
            for (int j = items.Count - 1; j >= i; j--)
            {

                if (items[j].CompareTo(items[j - 1]) < 0) // obj is smaller
                {
                    IComparable tmp = items[j];
                    items[j] = items[j - 1];
                    items[j - 1] = tmp;
                }
            }
        }
    }
}
