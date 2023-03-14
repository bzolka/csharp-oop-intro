namespace Events;

public delegate void LogHandler(string msg);

/// <summary>
/// Több előfizetőt támogató naplózó osztály.
/// </summary>
class Logger
{

    /// <summary>
    /// A naplózás eseménye. Akkor sül el, amikor új naplózandó szöveg érkezik, erről
    /// az összes előfizető értesítést kap.
    /// </summary>
    // Figyeljük meg: egy osztálynak .NET-nem nem csak tagváltozója és tagfüggvénye
    // lehet, hanem property-je és event-je is!
    public event LogHandler Log;

    /// <summary>
    /// Naplózza a szöveget, de eléírja az aktuális időt is.
    /// </summary>
    /// <param name="msg">A naplózandó szöveg.</param>
    public void WriteLine(string msg)
    {
        // Esemény elsütése: meghívódik az összes előfizető beregisztrált függvénye.
        if (Log != null)
            Log($"{DateTime.Now.ToString()} {msg}");
    }
}

/// <summary>
/// Fájlba naplózó osztály.
/// </summary>
class FileLogListener
{
    /// <summary>
    /// Szöveg fájlba írására a StreamWriter osztályt használjuk ("nyers" bájtok
    /// fájba írására a FileStream használatos).
    /// </summary>
    private StreamWriter streamWriter;

    /// <summary>
    /// A konstruktorban inicializáljuk a StreamWritert
    /// </summary>
    /// <param name="filePath"></param>
    public FileLogListener(string filePath)
    {
        streamWriter = new StreamWriter(filePath, true);
    }

    /// <summary>
    /// Kiírja a fájl adatfolyamba a szöveget.
    /// </summary>
    /// <param name="msg">A naplózandó szöveg.</param>
    public void WriteToFile(string msg)
    {
        streamWriter.WriteLine(msg);
    }

    /// <summary>
    /// Lezárja a naplózó objektumot.
    /// </summary>
    public void Close()
    {
        streamWriter.Close();
    }
}

/// <summary>
/// Az alkalmazást reprezentáló osztály.
/// </summary>
class App
{
    Logger log = new Logger();
    FileLogListener fileLogListener = new FileLogListener("applog.txt");

    public App()
    {
        // Előfizetünk az eseményre két módon is.
        log.Log += new LogHandler(writeConsole);
        log.Log += new LogHandler(fileLogListener.WriteToFile);
    }

    public void Process()
    {
        // Az adatfeldolgozás során naplózunk, ami elsüti a log objektum
        // Log eseményét, meghívódnak a beregisztrált kezelőfüggvények.
        log.WriteLine("Process begin...");
        //...
        log.WriteLine("Process end...");
    }

    public void Cleanup()
    {
        // Takarításkor leíratkozunk az eseményről.
        log.Log -= new LogHandler(writeConsole);
        log.Log -= new LogHandler(fileLogListener.WriteToFile);
        fileLogListener.Close();
    }

    /// <summary>
    /// Kiírja a konzolra a paraméterként megkapott szöveget.
    /// </summary>
    /// <param name="msg">The MSG.</param>
    void writeConsole(string msg)
    {
        Console.WriteLine(msg);
    }
}

class Program
{
    static void Main(string[] args)
    {
        App app = new App();
        app.Process();
        app.Cleanup();
    }
}
