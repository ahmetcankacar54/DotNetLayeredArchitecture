using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.Order.GetByIdOrder;

public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQueryRequest, GetByIdOrderQueryResponse>
{
    protected readonly IOrderRepository _orderRepository;

    public GetByIdOrderQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<GetByIdOrderQueryResponse> Handle(GetByIdOrderQueryRequest request, CancellationToken cancellationToken)
    {
        var order = await _orderRepository.GetById(request.Id);
        return new GetByIdOrderQueryResponse()
        {
            Order = order
        };
    }
}