using CelilCavus.cryptop.web.Interface;
using CelilCavus.cryptop.web.Models.Contexts;
using CelilCavus.cryptop.web.Repository;

namespace CelilCavus.cryptop.web.UnitofWork
{
    public class Uow : IUow
    {
        private readonly AppContext _context;

        public Uow(AppContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}