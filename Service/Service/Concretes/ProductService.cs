using AutoMapper;
using Data;
using Data.Entities.Concretes;
using Mediator.Commands.Product.CreateProduct;
using Mediator.Commands.Product.DeleteProduct;
using Mediator.Commands.Product.UpdateProduct;
using Mediator.Queries.Product.GetAllProduct;
using Mediator.Queries.Product.GetByIdProduct;
using MediatR;
using Models.Dto;
using Service.Interfaces;

namespace Service.Concretes
{
    public class ProductService : IProductService
    {
        protected  readonly IMediator _mediator;
        protected readonly IMapper _mapper;

        public ProductService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public async Task<GetAllProductQueryResponse> GetAll()
        {
            return await _mediator.Send(new GetAllProductQueryRequest());
        }

        public async Task<CreateProductCommandResponse> Add(ProductDto productDto)
        {
            var entity = _mapper.Map<Product>(productDto);
            CreateProductCommandResponse response = await _mediator.Send(new CreateProductCommandRequest(entity));
            return response;
        }

        public async Task<GetByIdProductQueryResponse> GetById(int Id)
        {
            return await _mediator.Send(new GetByIdProductQueryRequest(Id));
        }

        public async Task<UpdateProductCommandResponse> Update(ProductUpdateDto productDto)
        {
            var entity = _mapper.Map<Product>(productDto);
            return await _mediator.Send(new UpdateProductCommandRequest(entity));
        }

        public async Task<DeleteProductCommandResponse> DeleteAsync(int Id)
        {
            return await _mediator.Send(new DeleteProductCommandRequest(Id));
        }
    }
}
