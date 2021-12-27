using CopiaFacebook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Core.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAll();
        Task<Post> GetById(int id);
        Task<List<Post>> GetPostsActive();
        Task<List<Post>> GetPostByUserId(int idUser);
        Task Create(Post post);
        Task SaveChangesAsync();
    }
}
