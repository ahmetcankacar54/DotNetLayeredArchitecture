using MediatR;
using Models.Dto;

namespace Mediator.Commands.User.CreateUser;

public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
{

    public Data.Entities.Concretes.User User { get; set; }

    public CreateUserCommandRequest(Data.Entities.Concretes.User user)
    {
        User = user;
    }
}