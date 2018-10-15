namespace KatalogPojazdow.Properties.pl.wiktor._abstract {
    public abstract class Pojazd {
        
        private string rodzajNapedu;
        private string gdzieSiePorusza;
        private int iloscOsobNaPokladzie;
        private bool czyUzywaPaliwo;
        private bool czyPosiadaKola;

        public abstract void start();
        public abstract void stop();

        protected Pojazd( string rodzajNapedu, int iloscOsobNaPokladzie,
            bool czyUzywaPaliwo, bool czyPosiadaKola) {
            this.rodzajNapedu = rodzajNapedu;
            this.iloscOsobNaPokladzie = iloscOsobNaPokladzie;
            this.czyUzywaPaliwo = czyUzywaPaliwo;
            this.czyPosiadaKola = czyPosiadaKola;
        }


        public string RodzajNapedu {
            get => rodzajNapedu;
            set => rodzajNapedu = value;
        }

        public string GdzieSiePorusza {
            get => gdzieSiePorusza;
            set => gdzieSiePorusza = value;
        }

        public int IloscOsobNaPokladzie {
            get => iloscOsobNaPokladzie;
            set => iloscOsobNaPokladzie = value;
        }

        public bool CzyUzywaPaliwo {
            get => czyUzywaPaliwo;
            set => czyUzywaPaliwo = value;
        }

        public bool CzyPosiadaKola {
            get => czyPosiadaKola;
            set => czyPosiadaKola = value;
        }
    }
}