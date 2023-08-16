using MediatR;

namespace Mediator.Queries.Brand.GetByIdBrand;

public class GetByIdBrandQueryRequest : IRequest<GetByIdBrandQueryResponse>
{
    public int Id { get; set; }

    public GetByIdBrandQueryRequest(int id)
    {
        Id = id;
    }
}