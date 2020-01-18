using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eThreadingBar.WebAPI.Controllers
{
   

    public class KlijentController : BaseCRUDController<Model.Klijent, KlijentSearchRequest, KlijentInsertRequest, KlijentInsertRequest>
    {
        public KlijentController(ICRUDService<Model.Klijent, KlijentSearchRequest, KlijentInsertRequest, KlijentInsertRequest> service) : base(service)
        {
        }
    }
}