using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Clank = new HashSet<Clank>();
            KorisniciUloge = new HashSet<KorisniciUloge>();
            NagradnaIgra = new HashSet<NagradnaIgra>();
            Termin = new HashSet<Termin>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Clank> Clank { get; set; }
        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual ICollection<NagradnaIgra> NagradnaIgra { get; set; }
        public virtual ICollection<Termin> Termin { get; set; }
    }
}
