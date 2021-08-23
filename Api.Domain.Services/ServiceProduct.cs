using Api.Domain.Core.Interfaces.Repository;
using Api.Domain.Core.Services;
using Api.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Domain.Services
{
    public class ServiceProduct: ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct _repositoryProduct) : base(_repositoryProduct)
        {
            repositoryProduct = _repositoryProduct;
        }
    }
}
