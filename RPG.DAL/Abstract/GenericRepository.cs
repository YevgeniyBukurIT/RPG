using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RPG.DAL.Abstract
{
    public class GenericRepository<TKey, TEntity>: IRepository<TKey, TEntity> where TEntity : class
    {
        protected DbSet<TEntity> Set;

        public GenericRepository(RpgContext context)
        {
            Set = context.Set<TEntity>();
        }
            
        public TEntity Get(TKey key)
        {
            return Set.Find(key);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Set.ToList();
        }

        public void Update(TEntity entity)
        {
            Set.Update(entity);
        }

        public void Add(TEntity entity)
        {
            Set.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            Set.Remove(entity);
        }
    }
}