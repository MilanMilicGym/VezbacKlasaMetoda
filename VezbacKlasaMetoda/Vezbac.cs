using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbacKlasaMetoda
{
    internal class Vezbac
    {
        public string ImeVezbaca { get; set; }
        public int Visina { get; set; }
        public int Tezina { get; set; }
        public int Godina { get; set; }

        public void Trcanje()
        {
            Console.WriteLine(ImeVezbaca + " je trcao");


        }

        public void DizanjeTegova ()
        {
            Console.WriteLine(ImeVezbaca + " je dizao tegove");
        }

        public void PenjanjeNaRipstol ()
        {
            Console.WriteLine(ImeVezbaca + " se popeo na ripstol");
        }


    }
}
