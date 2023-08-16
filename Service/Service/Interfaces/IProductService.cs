using System;
using Mediator.Commands.Product.CreateProduct;
using Mediator.Commands.Product.DeleteProduct;
using Mediator.Commands.Product.UpdateProduct;
using Mediator.Queries.Product.GetAllProduct;
using Mediator.Queries.Product.GetByIdProduct;
using MediatR;
using Models.Dto;

namespace Service.Interfaces
{
	public interface IProductService 
	{
		public Task<GetAllProductQueryResponse> GetAll();
		public Task<CreateProductCommandResponse> Add(ProductDto productDto);
		public Task<GetByIdProductQueryResponse> GetById(int Id);
		public Task<UpdateProductCommandResponse> Update(ProductUpdateDto productDto);
		public Task<DeleteProductCommandResponse> DeleteAsync(int Id);

    }
}

