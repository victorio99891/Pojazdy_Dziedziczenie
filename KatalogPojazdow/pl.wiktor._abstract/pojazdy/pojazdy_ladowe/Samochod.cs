using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe {
    public class Samochod : PojazdLadowy {
        private int pojemnoscSilnika;

        public void otworzSzybe() {
            Console.Write("otwieranie/zamykanie szyby");
        }

        public Samochod(string rodzajNapedu, int iloscOsobNaPokladzie,
            bool czyUzywaPaliwo, bool czyPosiadaKola, int iloscKol, int pojemnoscSilnika) : base(rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo, czyPosiadaKola, iloscKol) {
            this.pojemnoscSilnika = pojemnoscSilnika;
        }

        virtual public void pokazDodatkoweMozliwosciSamochodu() {
            Console.WriteLine("(nieokreślony samochód nie ma dodatkowych właściwości)");
        }

        public override void start() {
            Console.Write("wciskanie pedału gazu");
        }

        public override void stop() {
            Console.Write("wciskanie pedału hamulca");
        }


        public int PojemnoscSilnika {
            get => pojemnoscSilnika;
            set => pojemnoscSilnika = value;
        }
    }
}