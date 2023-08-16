using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Order.UpdateOrder;

public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public UpdateOrderCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
    {
        var updatedUser = await UnitOfWork.OrderRepository.Update(request.Order);
        UnitOfWork.Commit();
        return new UpdateOrderCommandResponse()
        {
            UpdatedUser = updatedUser
        };
    }
}