using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            KlijentNotifikacija = new HashSet<KlijentNotifikacija>();
            NagradnaIgra = new HashSet<NagradnaIgra>();
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public int GradId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<KlijentNotifikacija> KlijentNotifikacija { get; set; }
        public virtual ICollection<NagradnaIgra> NagradnaIgra { get; set; }
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
