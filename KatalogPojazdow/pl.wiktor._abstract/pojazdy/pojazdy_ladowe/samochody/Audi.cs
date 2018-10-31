using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe.samochody {
    public class Audi : Samochod {
        public Audi(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo, bool czyPosiadaKola,
            int iloscKol, int pojemnoscSilnika) : base(rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo,
            czyPosiadaKola, iloscKol, pojemnoscSilnika) {
        }

        public override void pokazDodatkoweMozliwosciSamochodu() {
            Console.WriteLine("\n|                           DODATKI DLA KLASY SAMOCHODU " + GetType().Name);
            Console.WriteLine("|                           - napêd 4x4 Quattro");
            Console.Write("|                           ");
            Console.WriteLine("- ksenonowe reflektory szerokok¹tne ");
        }
    }
}