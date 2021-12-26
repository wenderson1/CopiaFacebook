using CopiaFacebook.Application.Commands.DeletePost;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Validators
{
    class DeletePostCommandValidator:AbstractValidator<DeletePostCommand>
    {
        public DeletePostCommandValidator()
        {

            RuleFor(p => p.Id)
                .GreaterThan(0)
                .WithMessage("Id do post precisa ser maior que 0");
        }
    }
}
