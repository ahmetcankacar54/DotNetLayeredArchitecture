using MediatR;
using Models.Dto;

namespace Mediator.Commands.Category.UpdateCategory;

public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryCommandResponse>
{
    public Data.Entities.Concretes.Category Category { get; set; }

    public UpdateCategoryCommandRequest(Data.Entities.Concretes.Category category)
    {
        Category = category;
    }
}