using System;
using System.Collections.Generic;
using System.Text;

namespace eThreadingBar.Model.Requests
{
   public class KlijentInsertRequest
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        public int GradId { get; set; }
    }
}
