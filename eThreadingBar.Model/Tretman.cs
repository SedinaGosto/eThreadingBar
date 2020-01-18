using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model
{
    public class Tretman
    {
        public int TretmanId { get; set; }
        public string Naziv { get; set; }
        public int Cijena { get; set; }
        public string NazivCijena { get { return Naziv + " " + Cijena+ " KM"; } }

    }
}
