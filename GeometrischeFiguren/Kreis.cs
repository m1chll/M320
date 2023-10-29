using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren;

public  class Kreis : Figur
{
    public float Durchmesser { get; set; }

    public Kreis(float durchmesser, float xKoordinate, float yKoordinate) : base(xKoordinate, yKoordinate)
    {
        if (durchmesser > 0)
        {
            Durchmesser= durchmesser;
        }
    }

    public override void PrintPosition()
    {
        Console.WriteLine($"X-Koordinate: {XKoordinate - Durchmesser / 2}, Y-Koordinate: {YKoordinate - Durchmesser / 2}");
    }

    public override void PrintArea()
    {
        Console.WriteLine($"Area: {(Durchmesser/2)*Math.PI}cm^2");
    }
}
