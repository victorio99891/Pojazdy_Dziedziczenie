using System;
using System.Collections.Generic;
using KatalogPojazdow.Properties.pl.wiktor._abstract;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe.samochody;

namespace KatalogPojazdow {
    public class FabrykaAudi : FabrykaPojazdow {
        private List<Pojazd> listaPojazdow;

        public FabrykaAudi(List<Pojazd> lista) {
            listaPojazdow = lista;
        }


        public void stworzPojazd() {
            Console.WriteLine("Witaj w Fabryce Audi:");
            Console.WriteLine("Podaj rodzaj nap�du samochodu: ");
            string rodzajnapedu = Console.ReadLine();
            Console.WriteLine("Podaj iloosobowy jest samochod: ");
            int ileOsob = Int32.Parse(Console.ReadLine());
            bool paliwo = true;
            bool kola = true;
            Console.WriteLine("Podaj ilo�� k�:");
            int iloscKol = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pojemno�� silnika: ");
            int pojemnoscSilnika = Int32.Parse(Console.ReadLine());

            Audi nowy = new Audi(rodzajnapedu, ileOsob, paliwo, kola, iloscKol, pojemnoscSilnika);

            listaPojazdow.Add(nowy);
        }
    }
}