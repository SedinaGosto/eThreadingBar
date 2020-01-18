using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
