using CopiaFacebook.Application.ViewModels;
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

namespace CopiaFacebook.Application.Queries.GetAllPosts
{
    public class GetAllPostsQueryHandler : IRequestHandler<GetAllPostsQuery, List<PostViewModel>>
    {
        private readonly IPostRepository _postRepository;

        public GetAllPostsQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostViewModel>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.GetAll();

            var postsViewModel = posts
                .Select(p => new PostViewModel(p.Description, p.CreatedAt, p.Status, p.UserId))
                .ToList();

            return postsViewModel;
        }
    }
}
