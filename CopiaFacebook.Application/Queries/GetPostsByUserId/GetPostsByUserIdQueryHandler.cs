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

namespace CopiaFacebook.Application.Queries.GetPostsByUserId
{
    public class GetPostsByUserIdQueryHandler : IRequestHandler<GetPostsByUserIdQuery, List<Post>>
    {
        private readonly IPostRepository _postRepository;

        public GetPostsByUserIdQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<Post>> Handle(GetPostsByUserIdQuery request, CancellationToken cancellationToken)
        {
            return await _postRepository.GetPostByUserId(request.IdUser);
        }
    }
}
