using Api.Application.Dtos;
using Api.Domain.Entitys;
using System.Collections.Generic;

namespace Api.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductModel productDto);
        ProductModel MapperEntityToDto(Product product);
        IEnumerable<ProductModel> MapperListProductDto(IEnumerable<Product> products);
        
    }
}
