using System;
using Mediator.Commands.Product.CreateProduct;
using Mediator.Commands.Product.DeleteProduct;
using Mediator.Commands.Product.UpdateProduct;
using Mediator.Queries.Product.GetAllProduct;
using Mediator.Queries.Product.GetByIdProduct;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using Repository.Repository.Interfaces;
using Service.Interfaces;

namespace WebApi.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase 
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<GetAllProductQueryResponse>> GetAll()
        {
            return await productService.GetAll();
        }
        
        [HttpPost]
        public async Task<ActionResult<CreateProductCommandResponse>> Add(ProductDto productDto)
        {
            return await productService.Add(productDto);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<GetByIdProductQueryResponse>> GetById(int id)
        {
            return await productService.GetById(id);
        }
        
        [HttpPut]
        public async Task<ActionResult<UpdateProductCommandResponse>> Update(ProductUpdateDto productDto)
        {
            return await productService.Update(productDto);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteProductCommandResponse>> Delete(int id)
        {
            
            return await productService.DeleteAsync(id);
        }


    }
}

