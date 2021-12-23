using CopiaFacebook.Core.Entities;
using CopiaFacebook.Infrastructure.Persistence;
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
        private readonly CopiaFacebookDbContext _dbContext;
        public PostController(CopiaFacebookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get(string query)
        {
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return NoContent();
        }

        [HttpGet("getPostsActive")]
        public IActionResult GetPostsActive(string query)
        {
            return NoContent();
        }

        [HttpGet("getPostsDeactive")]
        public IActionResult GetPostsDeactive(string query)
        {
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Post post)
        {
            await _dbContext.Posts.AddAsync(post);
            return Ok(post);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Post post)
        {
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
        
        
    }
}
