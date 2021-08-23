using Api.Domain.Core.Interfaces.Repository;
using Api.Domain.Core.Services;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Api.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> 
        where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> _repository)
        {
            repository = _repository;
        }

        public void Add(TEntity entity)
        {
            //Validate(entity, Activator.CreateInstance<TValidator>());
            repository.Add(entity);
        }

        

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            repository.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        private void Validate(TEntity entity, AbstractValidator<TEntity> validator)
        {
            if (entity == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(entity);
        }

    }
}
