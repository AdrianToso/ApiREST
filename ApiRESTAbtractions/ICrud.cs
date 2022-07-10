using System;
using System.Collections.Generic;

namespace ApiRESTAbtractions
{
    public interface ICrud<T>
    {
        T save(T entity);
        IList<T> GetAll();
        T GetById(int id);
        void Delete(int id);

    }
}
