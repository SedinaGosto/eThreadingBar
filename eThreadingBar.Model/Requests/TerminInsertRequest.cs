using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model.Requests
{
    public class TerminInsertRequest
    {
        public int Id { get; set; }
        public DateTime VrijemeTermina { get; set; }
        public bool Rezervisan { get; set; }
        public int KorisnikId { get; set; }
    }
}
