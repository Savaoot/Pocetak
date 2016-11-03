using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    public class Kurs
    {
        public Kurs()
        { 
        }

        public Kurs(string jezik, string tipKursa, double cenaKursa, List<Ucenik> listaUcenika, Nastavnik predavac)
        {
            Jezik = jezik;
            TipKursa = tipKursa;
            CenaKursa = cenaKursa;
            ListaUcenika = listaUcenika;
            Predavac = predavac;
        }

        //jezik uči, koji je tip kursa (nivo jezika), cena kursa, učenici koji pohađaju kurs i nastavnik koji ga predaje.


        public string Jezik { get; set; }
        public string TipKursa { get; set; }
        public double CenaKursa { get; set; }
        public List<Ucenik> ListaUcenika { get; set; }
        public Nastavnik Predavac { get; set; }
    }
}
