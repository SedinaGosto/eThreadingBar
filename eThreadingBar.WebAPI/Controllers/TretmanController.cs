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

    public class TretmanController : BaseCRUDController<Model.Tretman,TretmanSearchRequest, TretmanInsertRequest, TretmanInsertRequest>
    {
        public TretmanController(ICRUDService<Tretman, TretmanSearchRequest, TretmanInsertRequest, TretmanInsertRequest> service) : base(service)
        {
        }
    }
}