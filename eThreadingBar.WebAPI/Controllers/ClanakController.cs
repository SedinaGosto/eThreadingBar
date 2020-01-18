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
   
    public class ClanakController : BaseCRUDController<Model.Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakInsertRequest>
    {
        public ClanakController(ICRUDService<Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakInsertRequest> service) : base(service)
        {
        }
    }
}