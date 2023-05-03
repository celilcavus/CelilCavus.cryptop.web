using System.Collections.Generic;

namespace CelilCavus.cryptop.web.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);

        T GetById(int id);
        List<T> GetAll(bool IsNoTracking = true);
    }
}