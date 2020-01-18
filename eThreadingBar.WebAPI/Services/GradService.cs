using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;

namespace eThreadingBar.WebAPI.Services
{
    public class GradService : BaseCRUDService<Model.Grad,GradSearchRequest,Database.Grad,GradInsertRequest,GradInsertRequest>,ICRUDService<Model.Grad,GradSearchRequest,GradInsertRequest,GradInsertRequest>
    {
        public GradService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Grad> Get(GradSearchRequest search)
        {
         
            var query = _context.Grad.AsQueryable();
            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().StartsWith(search.Naziv.ToLower()));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Grad>>(list);
        }
     

   
      
    }
}
