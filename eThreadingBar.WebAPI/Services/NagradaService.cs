using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class NagradaService:BaseCRUDService<Model.Nagrada, NagradaSearchRequest, Database.Nagrada, NagradaInsertRequest, NagradaInsertRequest>, ICRUDService<Model.Nagrada, NagradaSearchRequest, NagradaInsertRequest, NagradaInsertRequest>
    {
        public NagradaService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
    {

    }

        public override List<Model.Nagrada> Get(NagradaSearchRequest search)
        {

            var query = _context.Nagrada.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv.ToLower()));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Nagrada>>(list);
        }
    }
}
