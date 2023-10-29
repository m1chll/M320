namespace GeometrischeFiguren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figuren = new List<Figur>();

            Rechteck rechteck1 = new Rechteck(4, 6, 2, 2);
            figuren.Add(rechteck1);
            Kreis kreis1 = new Kreis(3, 6, 7);
            figuren.Add(kreis1);
            Quadrat quadrat1 = new Quadrat(4, 6, 7);
            figuren.Add(quadrat1);

            foreach(var figur in figuren)
            {
                figur.PrintArea();
                figur.PrintPosition();
            }

            rechteck1.Rotate();
            rechteck1.PrintPosition();

        }
    }
}