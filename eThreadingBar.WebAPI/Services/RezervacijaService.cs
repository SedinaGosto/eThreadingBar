using AutoMapper;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class RezervacijaService: BaseCRUDService<Model.Rezervacija, RezervacijaSearchRequest, Database.Rezervacija, RezervacijaInsertRequest, RezervacijaInsertRequest>, ICRUDService<Model.Rezervacija, RezervacijaSearchRequest, RezervacijaInsertRequest, RezervacijaInsertRequest>
    {
    
        public RezervacijaService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Rezervacija> Get(RezervacijaSearchRequest search)
        {
            
            var query = _context.Rezervacija.AsQueryable();

           

                if (search.TretmanId.HasValue && search.Godina.HasValue)
                {
                    query = query.Where(x => x.TretmanId == search.TretmanId && x.DatumRezervacije.Year==search.Godina);
                }
                if (search.KlijentId.HasValue)
                {
                  if(search.Godina.HasValue)
                    query = query.Where(x => x.KlijentId == search.KlijentId && x.DatumRezervacije.Year == search.Godina);
                  else if(search.UposlenikId.HasValue)
                {
                    query = query.Where(x => x.Termin.KorisnikId == search.UposlenikId && x.KlijentId==search.KlijentId);

                }
                else
                query = query.Where(x => x.KlijentId == search.KlijentId );


            }
          
              if(search.TerminId.HasValue)
            {
                if(search.Godina.HasValue)
                query = query.Where(x => x.TerminId == search.TerminId && x.DatumRezervacije.Year == search.Godina);
                else
                    query = query.Where(x => x.TerminId == search.TerminId);


            }


            


            var list = query.OrderByDescending(x=>x.DatumRezervacije).ToList();
            return _mapper.Map<List<Model.Rezervacija>>(list);


        }
    }
}
