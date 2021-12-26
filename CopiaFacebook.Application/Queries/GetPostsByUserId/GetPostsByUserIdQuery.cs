using CopiaFacebook.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Queries.GetPostsByUserId
{
    public class GetPostsByUserIdQuery : IRequest<List<Post>>
    {
        public int IdUser { get; private set; }
    }
}
