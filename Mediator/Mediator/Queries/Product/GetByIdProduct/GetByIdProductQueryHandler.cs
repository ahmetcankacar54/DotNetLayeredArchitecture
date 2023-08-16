using MediatR;
using Repository.Repository.Concretes;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.Product.GetByIdProduct;

public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
{
    protected readonly IProductRepository _productRepository;

    public GetByIdProductQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetById(request.Id);
        return new GetByIdProductQueryResponse()
        {
            Product = product
        };
    }
}