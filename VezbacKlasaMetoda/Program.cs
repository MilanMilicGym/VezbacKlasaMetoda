using System;

namespace VezbacKlasaMetoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Milan = new Vezbac ();
            Milan.ImeVezbaca = "Milan";
            Milan.Visina = 183;
            Milan.Tezina = 88 ;
            Milan.Godina = 28;
            Console.WriteLine (Milan.ImeVezbaca + ", njegova visina je  " + Milan.Visina + ", njegova tezina je  " + Milan.Tezina + ", ima godina " + Milan.Godina);

            Milan.Trcanje();
           var Zoran = new Vezbac ();
            Zoran.ImeVezbaca = "Zoran";
            Zoran.DizanjeTegova();

            var Mica = new Vezbac ();
            Mica.ImeVezbaca = "Mica";

            Mica.PenjanjeNaRipstol();
        }
    }
}
