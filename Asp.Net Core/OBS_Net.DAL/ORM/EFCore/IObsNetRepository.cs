using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBS_Net.DAL.ORM.EFCore
{
    public interface IObsNetRepository<T> where T:class
    {
        IQueryable<T> GetQuery();
        List<T> Get();
        T Update(T model);
        T Find(Guid id);
        void Create(T model);
        void Delete(Guid id);
        void Delete(T model);
    }
}
