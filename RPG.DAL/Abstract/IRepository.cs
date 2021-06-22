using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RPG.DAL.Abstract
{
    public interface IRepository<TKey, TEntity>
    {
        TEntity Get(TKey key);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}