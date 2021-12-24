using CopiaFacebook.Application.Commands.CreatePost;
using CopiaFacebook.Application.Commands.DeletePost;
using CopiaFacebook.Application.Commands.UpdatePost;
using CopiaFacebook.Application.Queries.GetAllPosts;
using CopiaFacebook.Application.Queries.GetPostById;
using CopiaFacebook.Application.Queries.GetPostsActive;
using CopiaFacebook.Core.Entities;
using CopiaFacebook.Core.Repositories;
using CopiaFacebook.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Copia_Facebook.API.Controllers
{
    [Route("api/posts")]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var getAllPostsQuery = new GetAllPostsQuery(query);
            var posts = await _mediator.Send(getAllPostsQuery);

            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetPostByIdQuery(id);
            var post = await _mediator.Send(query);

            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpGet("getPostsActive")]
        public async Task<IActionResult> GetPostsActive(string query)
        {
            var getPostsActive = new GetPostsActiveQuery(query);
            var posts = await _mediator.Send(getPostsActive);

            return Ok(posts);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePostCommand command, IMediator mediator)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdatePostCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeletePostCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
