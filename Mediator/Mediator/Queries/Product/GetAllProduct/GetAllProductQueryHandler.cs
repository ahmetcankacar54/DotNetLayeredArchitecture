using MediatR;
using Repository.Repository.Concretes;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.Product.GetAllProduct;

public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
{
    protected readonly IProductRepository _productRepository;

    public GetAllProductQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
    {
        var products =  _productRepository.GetAll();
        
        return new GetAllProductQueryResponse()
        {
            Products = products
        };

    }
}