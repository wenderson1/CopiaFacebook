using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Commands.UpdatePost
{
    public class UpdatePostCommand:IRequest<Unit>
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
    }
}
