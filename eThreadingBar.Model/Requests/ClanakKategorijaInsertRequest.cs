using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model.Requests
{
    public class ClanakKategorijaInsertRequest
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumKreiranja { get; set; }
    }
}
