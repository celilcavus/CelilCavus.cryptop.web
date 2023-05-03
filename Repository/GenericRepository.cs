using CelilCavus.cryptop.web.Interface;
using CelilCavus.cryptop.web.Models.Contexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CelilCavus.cryptop.web.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly AppContext _context;

        public GenericRepository(AppContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public List<T> GetAll(bool IsNoTracking = true)
        {
                return IsNoTracking == true ? 
                    _context.Set<T>().AsNoTracking().ToList(): 
                    _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T item)
        {
            _context.Entry<T>(item).State = EntityState.Modified;
        }
    }
}