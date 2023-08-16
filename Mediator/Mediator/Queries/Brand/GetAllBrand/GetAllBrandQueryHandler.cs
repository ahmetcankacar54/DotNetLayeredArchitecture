using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.Brand.GetAllBrand;

public class GetAllBrandQueryHandler : IRequestHandler<GetAllBrandQueryRequest, GetAllBrandQueryResponse>
{
    protected readonly IBrandRepository _brandRepository;

    public GetAllBrandQueryHandler(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task<GetAllBrandQueryResponse> Handle(GetAllBrandQueryRequest request, CancellationToken cancellationToken)
    {
        var brands =  _brandRepository.GetAll();
        return new GetAllBrandQueryResponse()
        {
            Brands = brands
        };
    }
}