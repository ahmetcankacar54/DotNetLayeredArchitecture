using Mediator.Queries.Product.GetAllProduct;
using MediatR;
using Models.Dto;

namespace Mediator.Queries.Product.GetByIdProduct;

public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
{
    public int Id { get; set; }

    public GetByIdProductQueryRequest(int id)
    {
        Id = id;
    }
}