using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model
{
   public class KlijentNotifikacijaList
    {
        public int NotifikacijaId { get; set; }
        public string Uposlenik { get; set; }
        public string Tretman { get; set; }
        public string Cijena { get; set; }
        public int KlijentId { get; set; }
        public int RezervacijaId { get; set; }
        public DateTime DatumSlanja { get; set; }

        public string VrijemeTermina { get; set; }
        public string DatumRezervacije { get; set; }
    }
}
