using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Category.UpdateCategory;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }


    public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        var category = await UnitOfWork.CategoryRepository.Update(request.Category);
        UnitOfWork.Commit();
        return new UpdateCategoryCommandResponse()
        {
            UpdatedCategory = category
        };
    }
}