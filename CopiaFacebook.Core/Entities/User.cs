using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }

        public User(string name)
        {
            Name = name;
            CreatedAt = DateTime.Now;
            Active = true;
        }

        public void DeactiveAccount()
        {
            Active = false;
        }
    }
}
