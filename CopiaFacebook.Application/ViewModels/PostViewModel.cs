using CopiaFacebook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.ViewModels
{
    public class PostViewModel
    {
        public PostViewModel(string description, DateTime createdAt, bool status, int idUser)
        {
            Description = description;
            CreatedAt = createdAt;
            Status = status;
            IdUser = idUser;
        }

        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Status { get; private set; }
        public int IdUser { get; private set; }
    }
}
