using System.Collections.Generic;

namespace TechBytes.ApplicationLogic.Abstractions
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Add(T item);
        T Update(T item);
        bool Delete(T item);
    }
}
