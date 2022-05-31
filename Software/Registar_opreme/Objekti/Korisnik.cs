using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar_opreme.Objekti
{
    public abstract class Korisnik
    {
        public Korisnik(int ID, string korisnickoIme, string ime, string prezime, string lozinka)
        {
            this.ID = ID;
            KorisnickoIme = korisnickoIme;
            Ime = ime;
            Prezime = prezime;
            Lozinka = lozinka;
        }

        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return $"{KorisnickoIme} ({Ime} {Prezime})";
        }
    }
}
