using Api.Application.Dtos;
using FluentValidation;
using System.Collections.Generic;

namespace Api.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductModel productDto);
        void Update(ProductModel productDto);
        void Remove(ProductModel productDto);
        IEnumerable<ProductModel> GetAll();
        ProductModel GetById(int id);
    }
}
