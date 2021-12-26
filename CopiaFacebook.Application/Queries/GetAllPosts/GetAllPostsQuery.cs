using CopiaFacebook.Application.ViewModels;
using CopiaFacebook.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Queries.GetAllPosts
{
   public class GetAllPostsQuery:IRequest<List<PostViewModel>>
    {
        public string Query { get; private set; }

        public GetAllPostsQuery(string query)
        {
            Query = query;
        }
    }
}
