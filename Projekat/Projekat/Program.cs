using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat
{
    public class Program
    {
        static void Main(string[] args)
        {
            string unos;
            Osoba o = new Osoba("nikola", "Nikolic", "1535456");
            Osoba os = new Osoba();

            Console.WriteLine("Unesite ime");
            unos = Console.ReadLine();
            os.Ime = unos;

            Console.WriteLine("Unesite prezime");
            unos = Console.ReadLine();
            os.Prezime = unos;

            Console.WriteLine("Unesite jebi me");
            unos = Console.ReadLine();
            os.JMBG = unos;

            Console.WriteLine("Podaci o osobi su: ");
            Console.WriteLine(os.Ime + " " + os.Prezime + " " + os.JMBG);
            Console.WriteLine(os);

            Korisnik k = new Korisnik("Pero", "Nikic", "323452345", "Ludak", "345");
            Console.WriteLine(k);

        }
    }
}
