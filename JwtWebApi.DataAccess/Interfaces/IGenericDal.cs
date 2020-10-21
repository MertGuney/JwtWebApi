using JwtWebApi.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JwtWebApi.DataAccess.Interfaces
{
    public interface IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAll();
        Task<List<TEntity>> GetAllByFilter(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> GetById(int id);
        Task<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter);
        Task Uptade(TEntity entity);
        Task Add(TEntity entity);
        Task Remove(TEntity entity);

    }
}
