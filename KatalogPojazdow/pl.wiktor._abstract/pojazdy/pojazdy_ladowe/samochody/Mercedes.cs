using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe.samochody {
    public class Mercedes : Samochod {
        public Mercedes(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo, bool czyPosiadaKola,
            int iloscKol, int pojemnoscSilnika) : base(rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo,
            czyPosiadaKola, iloscKol, pojemnoscSilnika) {
        }

        public override void pokazDodatkoweMozliwosciSamochodu() {
            Console.WriteLine("\n|                           DODATKI DLA KLASY SAMOCHODU " + GetType().Name );
            Console.WriteLine("|                           - wersja wyposa¿enia AMG");
            Console.Write("|                           ");
            Console.WriteLine("- pe³ne wsparce serwisowe w serwisach Mercedes-Benz");
        }
    }
}