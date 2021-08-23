using Api.Application.Dtos;
using Api.Application.Interfaces;
using Api.Domain.Core.Services;
using Api.Domain.ValuesObject;
using Api.Infrastructure.CrossCutting.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Api.Application
{
    public class ApplicationServiceCategory : IApplicationServiceCategory
    {
        private readonly IServiceCategory serviceCategory;
        private readonly IMapperCategory mapperCategory;

        public ApplicationServiceCategory(IServiceCategory _serviceCategory, IMapperCategory _mappintCategory)
        {
            serviceCategory = _serviceCategory;
            mapperCategory = _mappintCategory;
        }


        public void Add(CategoryModel categoryDto)
        {
            serviceCategory.Add(mapperCategory.MapperDtoToEntity(categoryDto));
        }

        //public void (CategoryModel categoryModel) 
        //{
        //    //TEntity entity = (TEntity)Convert.ChangeType(mapperCategory.MapperDtoToEntity(categoryDto), typeof(TEntity));
        //    //Validate(entity, Activator.CreateInstance<TValidator>());
        //    serviceCategory.Add(mapperCategory.MapperDtoToEntity(categoryModel));
        //}

        public void Update(CategoryModel categoryModel)
        {
            serviceCategory.Update(mapperCategory.MapperDtoToEntity(categoryModel));
        }

        public void Remove(CategoryModel categoryModel)
        {
            serviceCategory.Remove(mapperCategory.MapperDtoToEntity(categoryModel));
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            return mapperCategory.MapperListCategoryDto(serviceCategory.GetAll());
        }

        public CategoryModel GetById(int id)
        {
            return mapperCategory.MapperEntityToDto(serviceCategory.GetById(id));
        }

        public CalculatedPriceViewModel CalculatedPrice(int id, double price)
        {
            if (price <= 0)
            {
                return new CalculatedPriceViewModel()
                {
                    FinalPrice = 0
                };
            }

            var category = mapperCategory.MapperEntityToDto(serviceCategory.GetById(id));
            CalculatedPriceViewModel calculatedPriceViewModel = new CalculatedPriceViewModel()
            {
                FinalPrice = price + price * (category.Margin / 100)
            };

            return calculatedPriceViewModel;
        }

    

        //private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        //{
        //    if (obj == null)
        //        throw new Exception("Registros não detectados!");

        //    validator.ValidateAndThrow(obj);
        //}



    }
}
