using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model
{
   public  class NagradnaIgra
    {
        public int NagradnaIgraId { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public string Opis { get; set; }
        public int NagradaId { get; set; }
        public int KlijentId { get; set; }
        public int? KorisnikId { get; set; }
    }
}
