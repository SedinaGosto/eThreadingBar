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
 
    public class GradController : BaseCRUDController<Model.Grad, GradSearchRequest, GradInsertRequest, GradInsertRequest>
    {
       
        public GradController(ICRUDService<Grad, GradSearchRequest, GradInsertRequest, GradInsertRequest> service) : base(service)
        {
        }
    }

}