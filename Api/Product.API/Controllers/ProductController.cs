using Api.Application.Dtos;
using Api.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Product.API.Controllers
{
    [Route("Product")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IApplicationServiceProduct _applicationServiceProduct;

        public ProductController(IApplicationServiceProduct applicationServiceProduct)
        {
            _applicationServiceProduct = applicationServiceProduct;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduct.GetAll());
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductModel productModel)
        {
            try
            {
                if (productModel == null)
                    return NotFound();

                _applicationServiceProduct.Add(productModel);
                return Ok("O produto foi salvo com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
