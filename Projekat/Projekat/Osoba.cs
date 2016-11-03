using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
   public class Osoba
    {
        // Konstruktori
        public Osoba()
        {
        }

        public Osoba(string ime, string prezime, string jmbg)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jmbg;
        }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string JMBG { get; set; }

        public override string  ToString()
        {
            return Ime + " " + Prezime + " " + JMBG;
        }

    }
}
