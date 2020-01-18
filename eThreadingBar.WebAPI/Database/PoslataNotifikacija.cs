using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class PoslataNotifikacija
    {
        public int Id { get; set; }
        public int RezervacijaId { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool IsProcitano { get; set; }

        public virtual Rezervacija Rezervacija { get; set; }
    }
}
