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


    public class BaseCRUDController<T, Tsearch,TInsert,TUpdate> : BaseController<T, Tsearch>
    {
        private readonly ICRUDService<T, Tsearch, TInsert, TUpdate> _service;
        public BaseCRUDController(ICRUDService<T, Tsearch,TInsert,TUpdate> service) : base(service)
        {
            _service = service;
        }
       
        [HttpPost]
        public T Insert(TInsert model)
        {
            return _service.Insert(model);
        }
        [HttpPut("{id}")]
        public T Update(int id,[FromBody] TUpdate model)
        {
            return _service.Update(id, model);
        }
        [HttpDelete("{id}")]

        public T Delete(int id)
        {
            return _service.Delete(id);

        }
    }
}