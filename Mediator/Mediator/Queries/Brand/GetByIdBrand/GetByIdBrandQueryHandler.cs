using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.Brand.GetByIdBrand;

public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQueryRequest, GetByIdBrandQueryResponse>
{
    protected readonly IBrandRepository _brandRepository;

    public GetByIdBrandQueryHandler(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task<GetByIdBrandQueryResponse> Handle(GetByIdBrandQueryRequest request, CancellationToken cancellationToken)
    {
        var brand = await _brandRepository.GetById(request.Id);
        return new GetByIdBrandQueryResponse()
        {
            Brand = brand
        };
    }
}