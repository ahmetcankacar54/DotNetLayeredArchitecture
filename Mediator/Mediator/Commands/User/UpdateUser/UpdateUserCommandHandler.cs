using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.User.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public UpdateUserCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
    {
        var user = await UnitOfWork.UserRepository.Update(request.User);
        UnitOfWork.Commit();
        return new UpdateUserCommandResponse()
        {
            UpdatedUser = user
        };
    }
}