using FluentValidation;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Exceptions;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestRegisterUserJson>
    {
        public RegisterUserValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage(ResourceMessagesException.NAME_EMPTY);
            RuleFor(x => x.email).NotEmpty();
            RuleFor(x => x.email).EmailAddress().WithMessage("Nao é um email válido");
            RuleFor(x => x.password.Length).GreaterThanOrEqualTo(6);
        }
    }
}
