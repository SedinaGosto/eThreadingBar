using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Termin
    {
        public Termin()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int Id { get; set; }
        public DateTime VrijemeTermina { get; set; }
        public bool Rezervisan { get; set; }
        public int? KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
