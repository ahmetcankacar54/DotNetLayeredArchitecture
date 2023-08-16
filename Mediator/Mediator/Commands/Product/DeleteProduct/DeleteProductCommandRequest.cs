using MediatR;

namespace Mediator.Commands.Product.DeleteProduct;

public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
{
    public int Id { get; set; }

    public DeleteProductCommandRequest(int id)
    {
        this.Id = id;
    }
}