using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class TretmanService : BaseCRUDService<Model.Tretman, TretmanSearchRequest, Database.Tretman, TretmanInsertRequest, TretmanInsertRequest>, ICRUDService<Model.Tretman, TretmanSearchRequest, TretmanInsertRequest, TretmanInsertRequest>
    {
        public TretmanService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Model.Tretman> Get(TretmanSearchRequest search)
        {

            var query = _context.Tretman.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv.ToLower()));
            }
           
            var list = query.ToList();
            return _mapper.Map<List<Model.Tretman>>(list);
        }
    }
}
