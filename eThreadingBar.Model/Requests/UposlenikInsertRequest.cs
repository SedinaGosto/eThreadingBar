using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model.Requests
{
    public class UposlenikInsertRequest
    {
        public int Id { get; set; }
        public string Imeprezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumZaposljenja { get; set; }
    }
}
