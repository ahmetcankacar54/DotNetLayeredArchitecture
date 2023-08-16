using MediatR;

namespace Mediator.Commands.Category.DeleteCategory;

public class DeleteCategoryCommandRequest : IRequest<DeleteCategoryCommandResponse>
{
    public int id { get; set; }

    public DeleteCategoryCommandRequest(int id)
    {
        this.id = id;
    }
}