using CelilCavus.cryptop.web.Interface;

namespace CelilCavus.cryptop.web.UnitofWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : class;

        int SaveChanges();
    }
}
