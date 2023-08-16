using Data;
using Data.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository.Repository.Interfaces;

namespace Repository.Repository.Concretes
{
	public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity: BaseEntity
    {

        protected readonly AppDbContext context;

        public BaseRepository(AppDbContext context)
        {
            this.context = context;
        }
        public DbSet<TEntity> Setter => context.Set<TEntity>();

        public async Task<bool> Add(TEntity entity)
        {
            await Setter.AddAsync(entity);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await Setter.FindAsync(id);
            if (entity == null)
            {
                return false;
            }

            Setter.Remove(entity);
            await context.SaveChangesAsync();
            
            return true;
        }

        public  IQueryable<TEntity> GetAll(bool tracking = true)
        {
            var query =  Setter.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public async Task<TEntity> GetById(int Id, bool tracking = true)
        {
            var query =  Setter.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(data => data.Id == Id);
        }
        
        public async Task<bool> Update(TEntity entity)
        {

            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return true;
        }
        
    }

}

