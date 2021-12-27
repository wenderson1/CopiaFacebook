using CopiaFacebook.Core.Entities;
using CopiaFacebook.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CopiaFacebookDbContext _dbContext;
        public UserRepository(CopiaFacebookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(User user)
        {

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<List<User>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<List<User>> GetUsersActive()
        {
            return await _dbContext.Users.Where(u => u.Active == true).ToListAsync();
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
