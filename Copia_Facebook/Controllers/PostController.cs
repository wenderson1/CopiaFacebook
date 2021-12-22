using CopiaFacebook.Core.Entities;
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
        public IActionResult Post([FromBody] Post post)
        {
            return NoContent();
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
