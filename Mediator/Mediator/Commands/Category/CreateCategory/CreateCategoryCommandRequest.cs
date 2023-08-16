using MediatR;
using Models.Dto;

namespace Mediator.Commands.Category.CreateCategory;

public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
{
    public Data.Entities.Concretes.Category Category { get; set; }

    public CreateCategoryCommandRequest(Data.Entities.Concretes.Category category)
    {
        Category = category;
    }
}