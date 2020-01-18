using AutoMapper;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class PoslataNotifikacijaService : BaseCRUDService<Model.PoslataNotifikacija, PoslataNotifikacijaSearchRequest, Database.PoslataNotifikacija, PoslataNotifikacijaInsertRequest, PoslataNotifikacijaInsertRequest>, ICRUDService<Model.PoslataNotifikacija, PoslataNotifikacijaSearchRequest, PoslataNotifikacijaInsertRequest, PoslataNotifikacijaInsertRequest>
    {
        public PoslataNotifikacijaService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.PoslataNotifikacija> Get(PoslataNotifikacijaSearchRequest search)
        {

            var query = _context.PoslataNotifikacija.AsQueryable();


           if(search.UposlenikId.HasValue)
            {
                query = query.Where(x => x.Rezervacija.Termin.KorisnikId == search.UposlenikId && x.IsProcitano==false);
            }
            if (search.RezervacijaId.HasValue)
            {
                query = query.Where(x => x.RezervacijaId == search.RezervacijaId);
            }


            query = query.OrderByDescending(x => x.DatumSlanja);
            var list = query.ToList();
            return _mapper.Map<List<Model.PoslataNotifikacija>>(list);
        }
    }
}
