using CopiaFacebook.Application.Commands.CreateUser;
using CopiaFacebook.Application.Commands.DeleteUser;
using CopiaFacebook.Application.Commands.UpdateUser;
using CopiaFacebook.Application.Queries.GetAllUsers;
using CopiaFacebook.Application.Queries.GetUserById;
using CopiaFacebook.Application.Queries.GetUsersActive;
using CopiaFacebook.Core.Entities;
using CopiaFacebook.Core.Repositories;
using CopiaFacebook.Infrastructure.Persistence;
using CopiaFacebook.Infrastructure.Persistence.Repositories;
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

        private readonly IMediator _mediator;
        private readonly IUserRepository _userRepository;
        public UserController(IMediator mediator, IUserRepository userRepository)
        {
            _mediator = mediator;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(string query)
        {
            var getAllUsersQuery = new GetAllUsersQuery(query);
            var users = await _mediator.Send(getAllUsersQuery);

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var getUserByIdQuery = new GetUserByIdQuery(id);
            var user = await _mediator.Send(getUserByIdQuery);

            if (user == null)
            {
                return NoContent();
            }

            return Ok(user);
        }

        [HttpGet("usersActive")]
        public async Task<IActionResult> GetUsersActive(string query)
        {
            var getUsersActiveQuery = new GetUsersActiveQuery(query);
            var users = await _mediator.Send(getUsersActiveQuery);

            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
          
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateUserCommand command)
        {

            var user = await _userRepository.GetById(id);

            if (id != command.Id)
            {
                return BadRequest("Id do Body é diferente do Id da Header");
            }

            if (user == null || user.Active == false)
            {
                return BadRequest("User não existe ou está desativado");
            }

            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userRepository.GetById(id);

            if (user == null || user.Active == false)
            {
                return BadRequest("Post não existe ou está desativado");
            }

            var command = new DeleteUserCommand(id);
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
