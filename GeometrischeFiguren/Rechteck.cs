using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren;

public class Rechteck : Figur, IRotation
{
    public float Breite { get; set; }
    public float Hoehe { get; set; }

    public Rechteck(float breite, float hoehe, float xKoordinate, float yKoordinate) : base(xKoordinate, yKoordinate)
    {
        if (breite > 0 && hoehe > 0)
        {
            Breite = breite;
            Hoehe = hoehe;
        }
    }
    public override void PrintPosition()
    {
        Console.WriteLine($"X-Koordinate: {XKoordinate}, Y-Koordinate: {YKoordinate}, Untere rechte Ecke: {XKoordinate + Breite} / {YKoordinate + Hoehe}");
    }

    public override void PrintArea()
    {
        Console.WriteLine($"Area: {Breite*Hoehe}cm^2");
    }

    public void Rotate()
    {
        XKoordinate += (Breite - Hoehe) / 2;
        YKoordinate += (Hoehe - Breite) / 2;
        
        float breite = Breite;  
        float hoehe = Hoehe;
        Breite = hoehe;
        Hoehe = breite;
    }
}
