using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model
{
    public class Rezervacija
    {
        public int Id { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public int KlijentId { get; set; }
        public int TerminId { get; set; }
        public int TretmanId { get; set; }
        public string Tretman { get; set; }
    }
}
