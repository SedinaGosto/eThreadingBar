using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model
{
    public class PoslataNotifikacija
    {

        public int Id { get; set; }
        public int RezervacijaId { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool IsProcitano { get; set; }

    }
}
