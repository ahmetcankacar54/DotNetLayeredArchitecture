using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Category.CreateCategory;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public CreateCategoryCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var category = await UnitOfWork.CategoryRepository.Add(request.Category);
        UnitOfWork.Commit();
        return new CreateCategoryCommandResponse()
        {
            Category = category
        };
    }
}