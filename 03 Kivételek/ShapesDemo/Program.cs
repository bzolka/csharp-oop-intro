namespace Exceptions1;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            double d;
            Console.WriteLine("Enter a nonzero number: ");
            d = Double.Parse(Console.ReadLine());
            if (d == 0)
                throw new Exception("The number can not be zero.");

            Console.WriteLine($"The inverse is: {1 / d}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error!, Invalid number format.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error! {e}");
        }
        finally
        {
            // Cleanup - nothing to cleanup now
        }

        Console.WriteLine("Done.");
        Console.ReadKey();
    }
}
