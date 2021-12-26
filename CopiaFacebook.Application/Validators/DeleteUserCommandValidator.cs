using CopiaFacebook.Application.Commands.DeleteUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Validators
{
  public class DeleteUserCommandValidator:AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            
            RuleFor(u => u.Id)
                .GreaterThan(0)
                .WithMessage("Id do usuário precisa ser maior que 0");
        }
    }
}
