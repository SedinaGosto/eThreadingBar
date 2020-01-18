using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eThreadingBar.WebAPI.Controllers
{
 
    public class KlijentNotifikacijaController : BaseCRUDController<Model.KlijentNotifikacija, KlijentNotifikacijaSearchRequest, KlijentNotifikacijaInsertRequest, KlijentNotifikacijaInsertRequest>
    {
        public KlijentNotifikacijaController(ICRUDService<Model.KlijentNotifikacija, KlijentNotifikacijaSearchRequest, KlijentNotifikacijaInsertRequest, KlijentNotifikacijaInsertRequest> service) : base(service)
        {
        }
    }
}