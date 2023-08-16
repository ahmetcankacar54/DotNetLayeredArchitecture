using MediatR;

namespace Mediator.Commands.Brand.DeleteBrand;

public class DeleteBrandCommandRequest : IRequest<DeleteBrandCommandResponse>
{
    public int id { get; set; }

    public DeleteBrandCommandRequest(int id)
    {
        this.id = id;
    }
}