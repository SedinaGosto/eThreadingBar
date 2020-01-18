using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model.Requests
{
    public class RezervacijaInsertRequest
    {
        public DateTime DatumRezervacije { get; set; }
        public int KlijentId { get; set; }
        public int TerminId { get; set; }
        public int TretmanId { get; set; }
    }
}
