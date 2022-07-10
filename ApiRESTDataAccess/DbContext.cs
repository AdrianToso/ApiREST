using ApiRESTAbstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;


namespace ApiRESTDataAccess
{
    public class DbContext<T> : IDbContext<T> where T : class , IEntity
    {
       DbSet<T> _items;
        ApiDbContext _ctx;
        public DbContext(ApiDbContext ctx)
        {
            _ctx = ctx;
            _items = ctx.Set<T>();
        }
        public void Delete(int id)
        {
         //   _items.Remove().Where(x => x.Id.Equals(id)).FirstOrDefault();
          
         }

        public IList<T> GetAll()
        {
            return _items.ToList();
        }

        public T GetById(int id)
        {
            return _items.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public T save(T entity)
        {
            _items.Add(entity);
            _ctx.SaveChanges();
            return entity;
        }
    }

    
}
