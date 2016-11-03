using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
   public class Korisnik : Osoba
    {
        // Konstruktori
        public Korisnik()
        {
        }

        public Korisnik(string ime, string prezime, string jmbg, string korisnikoIme, string lozinka) : base(ime, prezime, jmbg)
        {
            KorisnickoIme = korisnikoIme;
            Lozinka = lozinka;
        }

        // Properti
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public override string ToString()
        {
            return KorisnickoIme + " " + Lozinka;
        }
    }
}
