using FluentValidation;
using System.Collections.Generic;

namespace Api.Domain.Core.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
