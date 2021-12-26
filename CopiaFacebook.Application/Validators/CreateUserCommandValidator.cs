using CopiaFacebook.Application.Commands.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Validators
{
    public class CreateUserCommandValidator:AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(p => p.Name)
                .MaximumLength(50)
                .MinimumLength(2)
                .WithMessage("Nome deve ser no mínimo de 2 caracteres e máximo de 50");
        }
    }
}
