using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
   public interface ICRUDService<T,Tsearch,TInsert,TUpdate>:IService<T,Tsearch>
    {
        T Insert(TInsert model);
        T Update(int id, TUpdate model);
        T Delete(int id);



    }
}
