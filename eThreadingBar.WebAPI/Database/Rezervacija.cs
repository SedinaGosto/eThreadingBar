using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            KlijentNotifikacija = new HashSet<KlijentNotifikacija>();
            PoslataNotifikacija = new HashSet<PoslataNotifikacija>();
        }

        public int Id { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int KlijentId { get; set; }
        public int TerminId { get; set; }
        public int TretmanId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Termin Termin { get; set; }
        public virtual Tretman Tretman { get; set; }
        public virtual ICollection<KlijentNotifikacija> KlijentNotifikacija { get; set; }
        public virtual ICollection<PoslataNotifikacija> PoslataNotifikacija { get; set; }
    }
}
