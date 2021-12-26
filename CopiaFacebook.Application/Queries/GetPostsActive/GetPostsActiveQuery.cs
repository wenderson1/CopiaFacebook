using CopiaFacebook.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Queries.GetPostsActive
{
    public class GetPostsActiveQuery : IRequest<List<Post>>
    {
        public string Query { get; private set; }

        public GetPostsActiveQuery(string query)
        {
            Query = query;
        }
    }
}
