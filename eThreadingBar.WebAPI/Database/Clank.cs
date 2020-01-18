using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Clank
    {
        public int ClanakId { get; set; }
        public string Naslov { get; set; }
        public string TekstClanka { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Podnaslov { get; set; }
        public int ClanciKategorijaId { get; set; }
        public byte[] Slika { get; set; }
        public int? KorisnikId { get; set; }

        public virtual ClanciKategorija ClanciKategorija { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
