﻿using System;
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
    public class ClanakKategorijaDesktopController : BaseCRUDController<Model.ClanakKategorija, ClanakKategorijaSearchRequest, ClanakKategorijaInsertRequest, ClanakKategorijaInsertRequest>
    {
        public ClanakKategorijaDesktopController(ICRUDService<ClanakKategorija, ClanakKategorijaSearchRequest, ClanakKategorijaInsertRequest, ClanakKategorijaInsertRequest> service) : base(service)
        {
        }
    }
}