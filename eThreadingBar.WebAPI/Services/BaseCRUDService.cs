using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eThreadingBar.WebAPI.Database;
using Microsoft.AspNetCore.Authorization;

namespace eThreadingBar.WebAPI.Services
{
   
    public class BaseCRUDService<TModel, Tsearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, Tsearch, TDatabase>, ICRUDService<TModel,Tsearch, TInsert, TUpdate> where TDatabase:class
    {
        public BaseCRUDService(BeautyStudio2019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(TInsert model)
        {
            var entity = _mapper.Map<TDatabase>(model);
            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate model)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(model, entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

     
        public  virtual TModel  Delete(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

          

            _context.Set<TDatabase>().Remove(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

    }
}
