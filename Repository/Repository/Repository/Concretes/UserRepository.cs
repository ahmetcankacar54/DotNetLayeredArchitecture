using Data;
using Data.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repository.Repository.Interfaces;

namespace Repository.Repository.Concretes
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}

