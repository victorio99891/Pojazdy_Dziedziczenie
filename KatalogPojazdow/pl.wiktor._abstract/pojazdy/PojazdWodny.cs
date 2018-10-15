using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy {
    public abstract class PojazdWodny : Pojazd {
        private int poziomZanurzenia;

        protected PojazdWodny(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo,
            bool czyPosiadaKola, int poziomZanurzenia) : base(rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo,
            czyPosiadaKola) {
            this.poziomZanurzenia = poziomZanurzenia;
            GdzieSiePorusza = "po wodzie/pod wodą";
        }

        public int PoziomZanurzenia {
            get => poziomZanurzenia;
            set => poziomZanurzenia = value;
        }
    }
}