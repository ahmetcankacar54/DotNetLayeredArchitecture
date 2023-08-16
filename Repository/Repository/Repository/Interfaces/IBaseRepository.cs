using Data.Entities.Concretes;
using Models.Dto;

namespace Repository.Repository.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
	{
        IQueryable<TEntity> GetAll(bool tracking = true);
        Task<bool> Add(TEntity entity);
        Task<TEntity> GetById(int Id, bool tracking = true);
        Task<bool> Update(TEntity entity);
        Task<bool> DeleteAsync(int Id);
    }
}

