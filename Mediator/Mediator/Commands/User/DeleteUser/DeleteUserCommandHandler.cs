using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.User.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
{
    protected readonly IUserRepository _userRepository;

    public DeleteUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
    {
        await _userRepository.DeleteAsync(request.Id);
        return new DeleteUserCommandResponse();
    }
}