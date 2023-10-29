using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren;
public abstract class Figur
{
    public float XKoordinate { get; set; }  
    public float YKoordinate { get; set; }

    public Figur (float xKoordinate = 100, float yKoordinate = 100)
    {
        XKoordinate = xKoordinate;
        YKoordinate = yKoordinate;
    }

    public virtual void PrintPosition()
    {
        Console.WriteLine($"X-Koordinate: {XKoordinate}, Y-Koordinate: {YKoordinate}");
    }

    public abstract void PrintArea();
}

