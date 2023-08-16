using MediatR;
using Models.Dto;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Order.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public CreateOrderCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
    {
        var order = await UnitOfWork.OrderRepository.Add(request.Order);
        return new CreateOrderCommandResponse()
        {
            Order = order
        };
    }
}