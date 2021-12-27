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
    public class PostRepository : IPostRepository
    {
        private readonly CopiaFacebookDbContext _dbContext;
        public PostRepository(CopiaFacebookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Post post)
        {
            await _dbContext.Posts.AddAsync(post);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<List<Post>> GetAll()
        {
            return await _dbContext.Posts.ToListAsync();
        }

        public async Task<Post> GetById(int id)
        {
            return await _dbContext.Posts.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<Post>> GetPostByUserId(int idUser)
        {
            return await _dbContext.Posts.Where(p => p.UserId == idUser).ToListAsync();
        }

        public async Task<List<Post>> GetPostsActive()
        {
            return await _dbContext.Posts.Where(p => p.Status == true).ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
