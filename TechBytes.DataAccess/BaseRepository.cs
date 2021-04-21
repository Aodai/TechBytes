using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechBytes.ApplicationLogic.Abstractions;

namespace TechBytes.DataAccess
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        protected readonly TechBytesDBContext dbContext;

        public BaseRepository(TechBytesDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public T Add(T item)
        {
            var entity = dbContext.Add<T>(item);
            dbContext.SaveChanges();
            return entity.Entity;
        }

        public bool Delete(T item)
        {
            dbContext.Remove<T>(item);
            dbContext.SaveChanges();
            return true;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().AsEnumerable();
        }

        public T Update(T item)
        {
            var entity = dbContext.Update<T>(item);
            dbContext.SaveChanges();
            return entity.Entity;
        }
    }
}
