namespace ShapesDemo;

class Program
{
    static void Main(string[] args)
    {
        InstaceCounter ic1 = new InstaceCounter();
        InstaceCounter ic2 = new InstaceCounter();
        Console.WriteLine(InstaceCounter.Count);
        ic1 = null;
        Console.WriteLine(InstaceCounter.Count);
        GC.Collect();
        // Elaltatjuk a hívót 2000 msec-ra
        Console.WriteLine("Waiting 2 secs...");
        System.Threading.Thread.Sleep(2000);
        GC.Collect();
        Console.WriteLine(InstaceCounter.Count);

        Console.ReadKey();
    }
}
