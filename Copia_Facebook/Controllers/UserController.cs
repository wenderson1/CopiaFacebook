using CopiaFacebook.Application.Commands.CreateUser;
using CopiaFacebook.Core.Entities;
using CopiaFacebook.Infrastructure.Persistence;
using MediatR;
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
        private readonly CopiaFacebookDbContext _dbContext;
        private readonly IMediator _mediator;
        public UserController(CopiaFacebookDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
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
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            if (command.Name.Length > 50)
            {
                return BadRequest();
            }

            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
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
