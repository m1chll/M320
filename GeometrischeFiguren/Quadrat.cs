using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeometrischeFiguren;
public class Quadrat : Rechteck
{
    public float Breite { get; set; }
    public float Hoehe { get; set; }

    public Quadrat(float seitenlaenge, float xKoordinate, float yKoordinate) : base(seitenlaenge, seitenlaenge, xKoordinate, yKoordinate)
    {
        Breite = seitenlaenge;
        Hoehe = seitenlaenge;
    }


}
