using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.User.CreateUser;

public class CreateUserCommandHandler : 
                                        IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public CreateUserCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
    {
        var user = await UnitOfWork.UserRepository.Add(request.User);
        return new CreateUserCommandResponse()
        {
            User = user
        };
    }
}