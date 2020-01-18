using System;
using System.Collections.Generic;

namespace eThreadingBar.WebAPI.Database
{
    public partial class Tretman
    {
        public Tretman()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int TretmanId { get; set; }
        public string Naziv { get; set; }
        public int Cijena { get; set; }

        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
