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
    public class NagradnaIgraController : BaseCRUDController<Model.NagradnaIgra, NagradnaIgraSearchRequest, NagradnaIgraInsertRequest, NagradnaIgraInsertRequest>
    {
        public NagradnaIgraController(ICRUDService<NagradnaIgra, NagradnaIgraSearchRequest, NagradnaIgraInsertRequest, NagradnaIgraInsertRequest> service) : base(service)
        {
        }
    }
}