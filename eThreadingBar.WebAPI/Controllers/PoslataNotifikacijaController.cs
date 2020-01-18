using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eThreadingBar.WebAPI.Controllers
{
    

    public class PoslataNotifikacijaController : BaseCRUDController<Model.PoslataNotifikacija, PoslataNotifikacijaSearchRequest, PoslataNotifikacijaInsertRequest, PoslataNotifikacijaInsertRequest>
    {
        public PoslataNotifikacijaController(ICRUDService<PoslataNotifikacija, PoslataNotifikacijaSearchRequest, PoslataNotifikacijaInsertRequest, PoslataNotifikacijaInsertRequest> service) : base(service)
        {
        }
    }
}