using CopiaFacebook.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Copia_Facebook.API.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
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

        [HttpGet("usersActive")]
        public IActionResult GetUsersActive(string query)
        {
            return NoContent();
        }

        [HttpGet("usersDeactive")]
        public IActionResult GetUsersDeactive(string query)
        {
            return NoContent();
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]User user)
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
