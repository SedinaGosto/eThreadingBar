using eThreadingBar.Model.Requests;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eThreadingBar.WebAPI.Services
{
    public interface IGradService
    {
        List<Model.Grad> GetAll(GradSearchRequest search);

       Model.Grad GetById(int id);
        Model.Grad Insert(GradInsertRequest model);
        Model.Grad Update(int id,GradInsertRequest model);





    }
}
