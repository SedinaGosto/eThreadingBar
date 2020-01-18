using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Klijent = new HashSet<Klijent>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Klijent> Klijent { get; set; }
    }
}
