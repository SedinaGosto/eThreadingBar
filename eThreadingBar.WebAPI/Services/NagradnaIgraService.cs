using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class NagradnaIgraService : BaseCRUDService<Model.NagradnaIgra, NagradnaIgraSearchRequest, Database.NagradnaIgra, NagradnaIgraInsertRequest, NagradnaIgraInsertRequest>, ICRUDService<Model.NagradnaIgra, NagradnaIgraSearchRequest, NagradnaIgraInsertRequest, NagradnaIgraInsertRequest>
    {
        public NagradnaIgraService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Model.NagradnaIgra> Get(NagradnaIgraSearchRequest search)
        {

            var query = _context.NagradnaIgra.AsQueryable();
            if (search._NagradaId.HasValue)
            {
                query = query.Where(x =>x.NagradaId==search._NagradaId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.NagradnaIgra>>(list);
        }
    }
}
