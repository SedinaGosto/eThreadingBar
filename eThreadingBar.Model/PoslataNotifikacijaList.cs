using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model
{
    public class PoslataNotifikacijaList
    {
        public string Klijent { get; set; }
        public string DatumRezervacije { get; set; }
        public string Tretman { get; set; }
        public string VrijemeTermina { get; set; }
        public int RezervacijaId { get; set; }
        public int PoslataNotifikacijaId { get; set; }
        public int KlijentId { get; set; }
    }
}
