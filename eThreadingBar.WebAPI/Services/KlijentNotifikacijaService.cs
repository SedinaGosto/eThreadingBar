using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class KlijentNotifikacijaService:BaseCRUDService<Model.KlijentNotifikacija, KlijentNotifikacijaSearchRequest, Database.KlijentNotifikacija, KlijentNotifikacijaInsertRequest, KlijentNotifikacijaInsertRequest>, ICRUDService<Model.KlijentNotifikacija, KlijentNotifikacijaSearchRequest, KlijentNotifikacijaInsertRequest, KlijentNotifikacijaInsertRequest>
    {
        public KlijentNotifikacijaService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
    {
    }

    public override List<Model.KlijentNotifikacija> Get(KlijentNotifikacijaSearchRequest search)
    {

        var query = _context.KlijentNotifikacija.AsQueryable();


        if (search.KlijentId.HasValue)
        {
            query = query.Where(x => x.KlijentId == search.KlijentId && x.IsProcitano == false);
        }
            if (search.RezervacijaId.HasValue)
            {
                query = query.Where(x => x.RezervacijaId == search.RezervacijaId);
            }


            query = query.OrderByDescending(x => x.DatumSlanja);
        var list = query.ToList();
        return _mapper.Map<List<Model.KlijentNotifikacija>>(list);
    }

}
}
