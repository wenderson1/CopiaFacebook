using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Commands.UpdateUser
{
    public class UpdateUserCommand:IRequest<Unit>
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
