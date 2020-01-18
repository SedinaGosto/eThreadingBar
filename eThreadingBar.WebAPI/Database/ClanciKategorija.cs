using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class ClanciKategorija
    {
        public ClanciKategorija()
        {
            Clank = new HashSet<Clank>();
        }

        public int ClanciKategorijaId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumKreiranja { get; set; }

        public virtual ICollection<Clank> Clank { get; set; }
    }
}
