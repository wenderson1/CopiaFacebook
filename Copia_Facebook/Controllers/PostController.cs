using CopiaFacebook.Application.Commands.CreatePost;
using CopiaFacebook.Application.Commands.DeletePost;
using CopiaFacebook.Application.Commands.UpdatePost;
using CopiaFacebook.Application.Queries.GetAllPosts;
using CopiaFacebook.Application.Queries.GetPostById;
using CopiaFacebook.Application.Queries.GetPostsActive;
using CopiaFacebook.Application.Queries.GetPostsByUserId;
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
        private readonly IPostRepository _postRepository;

        public PostController(IMediator mediator, IPostRepository postRepository)
        {
            _mediator = mediator;
            _postRepository = postRepository;
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

        [HttpGet("getPostsByUserId/{userId}")]
        public async Task<IActionResult> GetPostsByUserId(int userId)
        {
            var getPostsByUserId = new GetPostsByUserIdQuery(userId);
            var posts = await _mediator.Send(getPostsByUserId);

            return Ok(posts);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePostCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,[FromBody] UpdatePostCommand command)
        {
            var post = await _postRepository.GetById(id);

            if(id != command.Id)
            {
                return BadRequest("Id do Body é diferente do Id da Header");
            }

            if(post == null || post.Status == false)
            {
                return BadRequest("Post não existe ou está desativado");
            }
            
            await _mediator.Send(command);
            
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeletePostCommand(id);
            var post = await _postRepository.GetById(id);

            if (post == null || post.Status == false)
            {
                return BadRequest("Post não existe ou está desativado");
            }

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
