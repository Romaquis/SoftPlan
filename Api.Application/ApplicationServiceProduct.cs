using Api.Application.Dtos;
using Api.Application.Interfaces;
using Api.Domain.Core.Services;
using Api.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;

namespace Api.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplicationServiceProduct(IServiceProduct _serviceProduct, IMapperProduct _mapperProduct)
        {
            serviceProduct = _serviceProduct;
            mapperProduct = _mapperProduct;
        }

        public void Add(ProductModel productDto) 
        {
            //TEntity entity = (TEntity)Convert.ChangeType(mapperProduct.MapperDtoToEntity(productDto), typeof(TEntity));
            //Validate(entity, Activator.CreateInstance<TValidator>());

            if (productDto.Description.Contains("Softplayer"))
            {
                productDto.CategoryId = 4;
            }
            serviceProduct.Add(mapperProduct.MapperDtoToEntity(productDto));
        }


        public void Update(ProductModel productDto)
        {
            serviceProduct.Update(mapperProduct.MapperDtoToEntity(productDto));
        }

        public void Remove(ProductModel productDto)
        {
            serviceProduct.Remove(mapperProduct.MapperDtoToEntity(productDto));
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return mapperProduct.MapperListProductDto(serviceProduct.GetAll());
        }

        public ProductModel GetById(int id)
        {
            return mapperProduct.MapperEntityToDto(serviceProduct.GetById(id));
        }

        //private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        //{
        //    if (obj == null)
        //        throw new Exception("Registros não detectados!");

        //    validator.ValidateAndThrow(obj);
        //}
    }
}
