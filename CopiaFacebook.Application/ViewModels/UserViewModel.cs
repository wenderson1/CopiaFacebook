using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Status { get; private set; }

        public UserViewModel(string name, DateTime createdAt, bool status)
        {
            Name = name;
            CreatedAt = createdAt;
            Status = status;
        }
    }
}
