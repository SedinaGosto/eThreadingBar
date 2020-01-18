using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class ClanakService:BaseCRUDService<Model.Clanak,ClanakSearchRequest,Database.Clank,ClanakInsertRequest,ClanakInsertRequest>
    {

        public ClanakService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Clanak> Get(ClanakSearchRequest search)
        {

            var query = _context.Clank.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naslov))
            {
                query = query.Where(x => x.Naslov.StartsWith(search.Naslov));
            }
            if(search.KategorijaId.HasValue)
            {
                query = query.Where(x => x.ClanciKategorijaId == search.KategorijaId.Value);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Clanak>>(list);
        }


    }
}
