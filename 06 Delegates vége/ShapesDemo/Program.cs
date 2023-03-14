using System.Collections;

namespace Delegates;

class Complex
{
    public double Re, Im;

    //  Konstruktor
    public Complex(double re, double im)
    {
        this.Re = re;
        this.Im = im;
    }
 }

// Delegate TÍPUS
delegate bool FirstIsSmallerDelegate(object a, object b);

class Sorter
{
    // A lista rendezése egy parametérkent kapott delegate segítségével.
    // Tetszőleges típusra használni szeretnénk. A T.f.h Complex forráskódja
    // nincs meg, nem tudjuk megoldani, hogy implementálja az
    // IComparable-t. Megoldás: átadjuk az összehasonlító "függvényt" is
    // paraméterként a HyperSort függvénynek.
    public static void HyperSort(ArrayList list,
        FirstIsSmallerDelegate firstIsSmaller)
    {
        for (int i = 1; i < list.Count; i++)
        {
            for (int j = list.Count - 1; j >= i; j--)
            {
                if (firstIsSmaller(list[j], list[j - 1]))
                {
                    object tmp = list[j];
                    list[j] = list[j - 1];
                    list[j - 1] = tmp;
                }
            }
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(new Complex(1, 3));
        list.Add(new Complex(1, 2));
        list.Add(new Complex(1, 1));
        // ...

        // Metódusreferencia statikus tagfüggvényre
        // Egyszerűsített szintaktika, ma már ezt használjuk
        Sorter.HyperSort(list, FirstIsSmaller_Complex);
        // Ez a teljes szintaktika
        Sorter.HyperSort(list, new FirstIsSmallerDelegate(FirstIsSmaller_Complex));

        // Metódusreferencia objektum tagfüggvényre (kicsit erőltetett,
        // itt ez is lehetne statikus.
        Comparers comps = new Comparers();
        Sorter.HyperSort(list, new FirstIsSmallerDelegate(comps.FirstIsSmaller_Complex));

        // A delegate egy típus, lehet lokális változó, tagváltozó is.
        FirstIsSmallerDelegate fis1 = new FirstIsSmallerDelegate(FirstIsSmaller_Complex);
        bool isFIS = fis1(new Complex(1, 1), new Complex(2, 2));

        // Minden delegate egy MultiCastDelegate leszármazott. Több metódusreferenciát
        // is tud tárolni. A += operátorral vehetők fel újak. Az alábbi példában kétszer
        // is beregisztráljuk a FirstIsSmaller_Complex függvényt és így kétszer is fog
        // meghívódni, nincs sok értelme. Majd az event-eknél látjuk, miért jó ez.
        FirstIsSmallerDelegate fis2 = FirstIsSmaller_Complex;
        fis1 += FirstIsSmaller_Complex;
        fis2(new Complex(1, 1), new Complex(2, 2));
    }

    public static bool FirstIsSmaller_Complex(object a, object b)
    {
        Complex ca = (Complex)a;
        Complex cb = (Complex)b;
        return Math.Sqrt(ca.Re * ca.Re + ca.Im * ca.Im) <
            Math.Sqrt(cb.Re * cb.Re + cb.Im * cb.Im);
    }
}

class Comparers
{
    public bool FirstIsSmaller_Complex(object a, object b)
    {
        // mint a Program osztályban
        Complex ca = (Complex)a;
        Complex cb = (Complex)b;
        return Math.Sqrt(ca.Re * ca.Re + ca.Im * ca.Im) <
            Math.Sqrt(cb.Re * cb.Re + cb.Im * cb.Im);
    }

    public bool FirstIsSmaller_Person(object a, object b)
    {
        throw new NotImplementedException();
    }
}
