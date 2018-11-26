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
            Console.WriteLine("| Nag³ówek fabryki pojazdów:                                    |");
            Console.WriteLine("----------------------------------------------------------------");
        }


        public void drukujStopke() {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("| Stopka fabryki pojazdów  :                                    |");
            Console.WriteLine("----------------------------------------------------------------");
        }

    }
}