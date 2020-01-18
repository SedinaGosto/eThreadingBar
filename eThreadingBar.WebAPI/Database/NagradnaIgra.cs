using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class NagradnaIgra
    {
        public int NagradnaIgraId { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public string Opis { get; set; }
        public int NagradaId { get; set; }
        public int KlijentId { get; set; }
        public int? KorisnikId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Nagrada Nagrada { get; set; }
    }
}
