using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Order.DeleteOrder;

public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
{
    protected readonly IOrderRepository _orderRepository;

    public DeleteOrderCommandHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
    {
        await _orderRepository.DeleteAsync(request.id);
        return new DeleteOrderCommandResponse();
    }
}