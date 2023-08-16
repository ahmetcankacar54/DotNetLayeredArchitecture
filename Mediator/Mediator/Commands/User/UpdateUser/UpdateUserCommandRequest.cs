using MediatR;
using Models.Dto;

namespace Mediator.Commands.User.UpdateUser;

public class UpdateUserCommandRequest : IRequest<UpdateUserCommandResponse>
{
    public Data.Entities.Concretes.User User;

    public UpdateUserCommandRequest(Data.Entities.Concretes.User user)
    {
        User = user;
    }
}