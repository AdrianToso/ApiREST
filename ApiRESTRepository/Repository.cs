﻿using ApiRESTAbstractions;
using ApiRESTAbtractions;
using System;
using System.Collections.Generic;

namespace ApiRESTRepository
{
    public interface IRepository<T>: ICrud<T>
    {

    }
    public class Repository<T> : IRepository<T> where T : IEntity

    {
        IDbContext<T> _ctx;

        public Repository(IDbContext<T> ctx)
        {
            _ctx = ctx;
        }

        public void Delete(int id)
        {
            _ctx.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _ctx.GetAll();
        }

        public T GetById(int id)
        {
            return _ctx.GetById(id);
        }

        public T save(T entity)
        {
          return _ctx.save(entity);
        }
    }
}
