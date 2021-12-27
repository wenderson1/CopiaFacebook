using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Core.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public List<Post> Posts { get; set; }

        public User(string name)
        {
            Name = name;
            CreatedAt = DateTime.Now;
            Active = true;
            Posts = new List<Post>();
        }

        public void DeactiveAccount()
        {
            Active = false;
        }

        public void Update(string name)
        {
            Name = name;
        }
    }
}
