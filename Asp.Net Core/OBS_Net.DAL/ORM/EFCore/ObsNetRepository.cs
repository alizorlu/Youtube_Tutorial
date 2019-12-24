using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBS_Net.DAL.ORM.EFCore
{
    public class ObsNetRepository<T> : IObsNetRepository<T> where T : class
    {

        private ObsContext db;
        private DbSet<T> tables;
        public ObsNetRepository(IConfiguration configuration)
        {
            db = new ObsContext(configuration);
            tables = db.Set<T>();
        }
        public void Create(T model)
        {
            tables.Add(model);
            db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            T finded = Find(id);
            if (finded == null) return;
            tables.Remove(finded);
            db.SaveChanges();
        }

        public void Delete(T model)
        {
            tables.Remove(model);
            db.SaveChanges();
        }

        public T Find(Guid id)
        {
            return tables.Find(id);
        }

        public List<T> Get()
        {
            return tables.ToList();
        }

        public T Update(T model)
        {
            tables.Update(model);
            db.SaveChanges();
            return model;
        }
    }
}
