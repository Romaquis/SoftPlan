using Api.Application.Dtos;
using Api.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperCategory
    {
        Category MapperDtoToEntity(CategoryModel categoryModel);
        CategoryModel MapperEntityToDto(Category categoryModel);
        IEnumerable<CategoryModel> MapperListCategoryDto(IEnumerable<Category> categories);
        
    }
}
