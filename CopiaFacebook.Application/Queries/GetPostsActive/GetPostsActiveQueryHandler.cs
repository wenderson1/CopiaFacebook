using CopiaFacebook.Core.Entities;
using CopiaFacebook.Core.Repositories;
using CopiaFacebook.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Queries.GetPostsActive
{
    public class GetPostsActiveQueryHandler : IRequestHandler<GetPostsActiveQuery, List<Post>>
    {
        private readonly IPostRepository _postRepository;

        public GetPostsActiveQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<Post>> Handle(GetPostsActiveQuery request, CancellationToken cancellationToken)
        {
            return await _postRepository.GetPostsActive();
        }
    }
}
