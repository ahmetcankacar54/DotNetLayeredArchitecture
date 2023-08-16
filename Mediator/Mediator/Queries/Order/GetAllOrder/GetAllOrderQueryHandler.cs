using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.Order.GetAllOrder;

public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQueryRequest, GetAllOrderQueryResponse>
{
    protected readonly IOrderRepository _orderRepository;

    public GetAllOrderQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<GetAllOrderQueryResponse> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
    {
        var orders =  _orderRepository.GetAll();
        return new GetAllOrderQueryResponse()
        {
            Orders = orders
        };
    }
}