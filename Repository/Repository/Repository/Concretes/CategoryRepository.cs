using Data;
using Data.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repository.Repository.Interfaces;

namespace Repository.Repository.Concretes
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}

