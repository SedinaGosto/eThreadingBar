using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class ClanakKategorijaService:BaseCRUDService<Model.ClanakKategorija,ClanakKategorijaSearchRequest,Database.ClanciKategorija,ClanakKategorijaInsertRequest,ClanakKategorijaInsertRequest>
    {
        public ClanakKategorijaService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.ClanakKategorija> Get(ClanakKategorijaSearchRequest search)
        {

            var query = _context.ClanciKategorija.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv.ToLower()));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.ClanakKategorija>>(list);
        }

    }
}
