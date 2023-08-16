using MediatR;

namespace Mediator.Commands.User.DeleteUser;

public class DeleteUserCommandRequest : IRequest<DeleteUserCommandResponse>
{
    public int Id { get; set; }

    public DeleteUserCommandRequest(int id)
    {
        this.Id = id;
    }
}