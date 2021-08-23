using Api.Application.Dtos;
using Api.Domain.ValuesObject;
using System.Collections.Generic;

namespace Api.Application.Interfaces
{
    public interface IApplicationServiceCategory
    {
        void Add(CategoryModel categoryDto);
        void Update(CategoryModel categoryDto);
        void Remove(CategoryModel categoryDto);
        IEnumerable<CategoryModel> GetAll();
        CategoryModel GetById(int id);

        CalculatedPriceViewModel CalculatedPrice(int id, double price);

    }
}
