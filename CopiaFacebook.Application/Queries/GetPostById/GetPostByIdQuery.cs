using CopiaFacebook.Application.ViewModels;
using CopiaFacebook.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Queries.GetPostById
{
   public class GetPostByIdQuery:IRequest<Post>
    {
        public int Id { get; private set; }

        public GetPostByIdQuery(int id)
        {
            Id = id;
        }
    }
}
