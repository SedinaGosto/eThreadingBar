using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class TerminService : BaseCRUDService<Model.Termin, TerminSearchRequest, Database.Termin, TerminInsertRequest, TerminInsertRequest>, ICRUDService<Model.Termin, TerminSearchRequest, TerminInsertRequest, TerminInsertRequest>
    {
        public TerminService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Termin> Get(TerminSearchRequest search)
        {

            var query = _context.Termin.AsQueryable();
            if (search.UposlenikId.HasValue == true)
            {
                if(search.Rezervisan)
                query = query.Where(x => x.KorisnikId == search.UposlenikId && x.Rezervisan == true);
                else if(!search.Rezervisan)
                 query = query.Where(x => x.KorisnikId == search.UposlenikId && x.Rezervisan == false);
                else
                    query = query.Where(x => x.KorisnikId == search.UposlenikId);


            }

            query = query.OrderByDescending(x => x.VrijemeTermina);
            var list = query.ToList();
            return _mapper.Map<List<Model.Termin>>(list);
        }
    }
}
