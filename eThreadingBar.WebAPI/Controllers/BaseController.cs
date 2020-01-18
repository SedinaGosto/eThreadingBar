using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eThreadingBar.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eThreadingBar.WebAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,Tsearch> : ControllerBase
    {
        private readonly IService<T,Tsearch> _service;
        public BaseController(IService<T,Tsearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<T>> Get([FromQuery]Tsearch search)
        {
            return _service.Get(search);
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }
 
    }
}