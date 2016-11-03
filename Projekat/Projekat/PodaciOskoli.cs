using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    public class PodaciOskoli
    {
        public PodaciOskoli()
        {

        }

        // Evidentira se naziv, adresa, telefon, email, adresa internet sajta, PIB, matični broj i broj žiro računa.

        public PodaciOskoli(string naziv, string adresa, string telefon, string email, string adresaInternetSajta,
                            string pib, string jmbg, string brojZiroRacuna)
        {
            Naziv = naziv;
            Adresa = adresa;
            Telefon = telefon;
            Email = email;
            AdresaInternetSajta = adresaInternetSajta;
            PIB = pib;
            JMBG = jmbg;
            BrojZiroRacuna = brojZiroRacuna;

        }

        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string AdresaInternetSajta { get; set; }
        public string PIB { get; set; }
        public string JMBG { get; set; }
        public string BrojZiroRacuna { get; set; }
    }
}
