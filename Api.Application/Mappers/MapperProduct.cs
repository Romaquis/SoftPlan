using Api.Application.Dtos;
using Api.Domain.Entitys;
using Api.Infrastructure.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Infrastructure.CrossCutting.Mapper
{
    public class MapperProduct : IMapperProduct
    {
        IEnumerable<ProductModel> productDtos = new List<ProductModel>();
        public Product MapperDtoToEntity(ProductModel productDto)
        {
            Product product = new Product()
            {
                Id = productDto.Id,
                Description = productDto.Description,
                Price = productDto.Price,
                CategoryId = productDto.CategoryId
            };

            return product;
        }

        public ProductModel MapperEntityToDto(Product product)
        {
            ProductModel productDto = new ProductModel()
            {
                Id = product.Id,
                Description = product.Description,
                Price = product.Price,
                CategoryId = product.CategoryId
            };

            return productDto;
        }

        public IEnumerable<ProductModel> MapperListProductDto(IEnumerable<Product> products)
        {
            var productDto = products.Select(p => new ProductModel {
                Id = p.Id,
                Description = p.Description,
                CategoryId = p.CategoryId
            });

            return productDto;
        }
    }
}
