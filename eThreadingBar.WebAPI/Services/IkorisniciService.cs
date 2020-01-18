using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public interface IkorisniciService
    {
        List<Model.Korisnici> Get(KorisniciSearchRequest request);

        Model.Korisnici GetById(int id);

        Model.Korisnici Insert(KorisniciInsertRequest request);

        Model.Korisnici Update(int id, KorisniciInsertRequest request);

        Model.Korisnici Authenticiraj(string username, string pass);
    }
}
