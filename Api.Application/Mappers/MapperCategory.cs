using Api.Application.Dtos;
using Api.Domain.Entitys;
using Api.Infrastructure.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Infrastructure.CrossCutting.Mapper
{
    public class MapperCategory: IMapperCategory
    {
        public Category MapperDtoToEntity(CategoryModel categoryDto)
        {
            return new Category()
            {
                Id = categoryDto.Id,
                Title = categoryDto.Title,
                Margin = categoryDto.Margin
            };
        }

        public CategoryModel MapperEntityToDto(Category category)
        {
            return new CategoryModel()
            {
                Id = category.Id,
                Title = category.Title,
                Margin = category.Margin
            };
        }

        public IEnumerable<CategoryModel> MapperListCategoryDto(IEnumerable<Category> categories)
        {
            return categories.Select(c => new CategoryModel { Id = c.Id, Title = c.Title, Margin = c.Margin});
        }
    }
}
