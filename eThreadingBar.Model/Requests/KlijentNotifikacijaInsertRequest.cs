using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model.Requests
{
    public class KlijentNotifikacijaInsertRequest
    {
        public int NotifikacijaId { get; set; }
        public int KlijentId { get; set; }
        public int RezervacijaId { get; set; }
        public DateTime DatumSlanja { get; set; }
        public bool IsProcitano { get; set; }
    }
}
