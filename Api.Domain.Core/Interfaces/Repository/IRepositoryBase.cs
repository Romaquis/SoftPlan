using FluentValidation;
using System.Collections.Generic;

namespace Api.Domain.Core.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
