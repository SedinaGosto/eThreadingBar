using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Nagrada
    {
        public Nagrada()
        {
            NagradnaIgra = new HashSet<NagradnaIgra>();
        }

        public int NagradaId { get; set; }
        public string Naziv { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<NagradnaIgra> NagradnaIgra { get; set; }
    }
}
