using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eThreadingBar.Model;
using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using eThreadingBar.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eThreadingBar.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class KorisniciController : ControllerBase
    {
        private readonly IkorisniciService _service;
        public KorisniciController(IkorisniciService service)
        {
            _service = service;
            
        }
        [HttpGet]
        public List<Model.Korisnici> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
            
        }

       
        [HttpPost]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }

  
        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, [FromBody]KorisniciInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}