using CopiaFacebook.Application.Commands.CreatePost;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopiaFacebook.Application.Validators
{
   public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandValidator()
        {
            RuleFor(p => p.Description)
                .MaximumLength(200)
                .MinimumLength(20)
                .WithMessage("Descrição do post precisa ser maior que 20 e menor que 200");

            RuleFor(p => p.IdUser)
                .GreaterThan(0)
                .WithMessage("Id do usuário precisa ser maior que 0");
        }
    }
}
