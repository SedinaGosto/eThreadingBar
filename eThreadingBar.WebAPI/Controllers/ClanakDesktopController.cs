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
   [Authorize(Roles = "Administrator")]

    public class ClanakDesktopController : BaseCRUDController<Model.Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakInsertRequest>
    {
        public ClanakDesktopController(ICRUDService<Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakInsertRequest> service) : base(service)
        {
        }
    }
}