using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model.Requests
{
    public class NagradaInsertRequest
    {
        public int NagradaId { get; set; }
        public string Naziv { get; set; }
        public byte[] Photo { get; set; }
    }
}
