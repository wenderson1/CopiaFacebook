using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Core.Entities
{
    public class Post
    {
        public Post(string description, int userId)
        {
            Description = description;
            Status = true;
            CreatedAt = DateTime.Now;
            UserId = userId;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }
        public bool Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }

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
