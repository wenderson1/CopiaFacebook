using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Commands.CreatePost
{
    public class CreatePostCommand:IRequest<int>
    {
        public string Description { get; private set; }
        public int IdUser { get; private set; }

        public CreatePostCommand(string description, int idUser)
        {
            Description = description;
            IdUser = idUser;
        }
    }
}
