using System.Linq;

namespace Group1.Framework.Persistence
{
    public interface IRepository<TEntity> : IQueryable<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        TEntity Add(TEntity newEntity);
        void Remove(TEntity entity);
    }
}
