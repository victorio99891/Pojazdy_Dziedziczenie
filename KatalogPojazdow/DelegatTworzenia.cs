using System;

namespace KatalogPojazdow {
    public class DelegatTworzenia {
        public delegate void Fabryka();

        public Fabryka FabrykaDelegat;

        public DelegatTworzenia() {
            FabrykaDelegat = drukujNaglowek;
            FabrykaDelegat += drukujStopke;
        }
        public void drukujNaglowek() {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("| Nag��wek fabryki pojazd�w:                                    |");
            Console.WriteLine("----------------------------------------------------------------");
        }


        public void drukujStopke() {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("| Stopka fabryki pojazd�w  :                                    |");
            Console.WriteLine("----------------------------------------------------------------");
        }

    }
}