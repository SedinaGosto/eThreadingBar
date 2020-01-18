using AutoMapper;
using eThreadingBar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eThreadingBar.WebAPI.Services
{
    public class BaseService<TModel, Tsearch,TDatabase> : 
        IService<TModel, Tsearch> where TDatabase:class
    {
        protected readonly BeautyStudio2019Context _context;
        protected readonly IMapper _mapper;
        public BaseService(BeautyStudio2019Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }   
        public virtual List<TModel> Get(Tsearch search)
        {

            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var list = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(list);
        }


    }
}
