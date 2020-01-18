using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model
{
   public  class Clanak
    {
        public int ClanakId { get; set; }
        public string Naslov { get; set; }
        public string TekstClanka { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Podnaslov { get; set; }
        public int ClanciKategorijaId { get; set; }
        public byte[] Slika { get; set; }
        public int? KorisnikId { get; set; }
    }
}
