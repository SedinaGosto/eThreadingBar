﻿using System;
using System.Collections.Generic;
using System.Text;


namespace eThreadingBar.Model
{
    public partial class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string FirstLastName { get { return Ime + " " + Prezime; } }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }

        //public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
