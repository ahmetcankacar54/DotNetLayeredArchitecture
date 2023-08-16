using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Category.DeleteCategory;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
{
    protected readonly ICategoryRepository _categoryRepository;

    public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        await _categoryRepository.DeleteAsync(request.id);
        return new DeleteCategoryCommandResponse();
    }
}