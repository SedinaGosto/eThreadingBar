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

    public class TerminController : BaseCRUDController<Model.Termin, TerminSearchRequest, TerminInsertRequest, TerminInsertRequest>
    {
        public TerminController(ICRUDService<Termin, TerminSearchRequest, TerminInsertRequest, TerminInsertRequest> service) : base(service)
        {
        }
    }
}