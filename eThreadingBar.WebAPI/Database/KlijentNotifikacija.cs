using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class KlijentNotifikacija
    {
        public int NotifikacijaId { get; set; }
        public int KlijentId { get; set; }
        public int RezervacijaId { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool IsProcitano { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }
    }
}
