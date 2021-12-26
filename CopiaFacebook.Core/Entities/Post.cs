using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Core.Entities
{
    public class Post:BaseEntity
    {
        public Post(string description, int idUser)
        {
            Description = description;
            Status = true;
            CreatedAt = DateTime.Now;
            IdUser = idUser;
        }

        public string Description { get; private set; }
        public bool Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int  IdUser { get; private set; }
        public User Client { get; private set; }

        public void DeactivePost()
        {
            Status = false;
        }

        public void Update(string description)
        {
            Description = description;
        }

    }
}
