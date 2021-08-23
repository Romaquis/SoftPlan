using Api.Domain.Core.Interfaces.Repository;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext _sqlContext)
        {
            sqlContext = _sqlContext;
        }
        public void Add(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(entity);
                sqlContext.SaveChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                sqlContext.Entry(entity).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(entity);
                sqlContext.SaveChanges();

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return sqlContext.Set<TEntity>().ToList();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return sqlContext.Set<TEntity>().Find(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
