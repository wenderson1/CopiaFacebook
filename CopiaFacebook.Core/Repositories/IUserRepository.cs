using CopiaFacebook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Core.Repositories
{
   public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
        Task<List<User>> GetUsersActive();
        Task<int> Create(User user);
        Task SaveChangesAsync();
        

    }
}
