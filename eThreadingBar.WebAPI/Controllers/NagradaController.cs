using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eThreadingBar.WebAPI.Controllers
{
    [Authorize(Roles="Administrator")]
    public class NagradaController : BaseCRUDController<Model.Nagrada, NagradaSearchRequest, NagradaInsertRequest, NagradaInsertRequest>
    {
        public NagradaController(ICRUDService<Nagrada, NagradaSearchRequest, NagradaInsertRequest, NagradaInsertRequest> service) : base(service)
        {
        }
    }
}