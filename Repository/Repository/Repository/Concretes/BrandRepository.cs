using Data;
using Data.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repository.Repository.Interfaces;

namespace Repository.Repository.Concretes
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {
        }
        
        
    }
}

