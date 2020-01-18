using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik, Model.KorisnikLogin>();
            CreateMap<Database.Klijent, Model.KorisnikLogin>();

            CreateMap<Database.Klijent, Model.Klijent>();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Grad, GradInsertRequest>().ReverseMap();
            CreateMap<Database.Klijent, KlijentInsertRequest>().ReverseMap();
            CreateMap<Database.Tretman, Model.Tretman>();
            CreateMap<Database.Tretman,TretmanInsertRequest>().ReverseMap();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();


            CreateMap<Database.Nagrada, Model.Nagrada>();
            CreateMap<Database.Nagrada, NagradaInsertRequest>().ReverseMap();
            CreateMap<Database.NagradnaIgra, Model.NagradnaIgra>();
            CreateMap<Database.NagradnaIgra, NagradnaIgraInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Korisnici>();
            CreateMap<Database.Korisnik, KorisniciInsertRequest>().ReverseMap();

            CreateMap<Database.Termin, Model.Termin>();
            CreateMap<Database.Uloga, Model.Uloge>();
            CreateMap<Database.Termin, TerminInsertRequest>().ReverseMap();

            CreateMap<Database.ClanciKategorija, Model.ClanakKategorija>();

            CreateMap<Database.ClanciKategorija, ClanakKategorijaInsertRequest>().ReverseMap();



            CreateMap<Database.Clank, Model.Clanak>();
            CreateMap<Database.Rezervacija, Model.Rezervacija>();
            CreateMap<Database.Rezervacija, RezervacijaInsertRequest>().ReverseMap();
            CreateMap<Database.Clank, ClanakInsertRequest>().ReverseMap();

            CreateMap<Database.PoslataNotifikacija, Model.PoslataNotifikacija>();
            CreateMap<Database.PoslataNotifikacija, PoslataNotifikacijaInsertRequest>().ReverseMap();


            CreateMap<Database.KlijentNotifikacija, Model.KlijentNotifikacija>();
            CreateMap<Database.KlijentNotifikacija, KlijentNotifikacijaInsertRequest>().ReverseMap();




        }
    }
}
