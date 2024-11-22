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
            RuleFor(x => x.email).NotEmpty().WithMessage(ResourceMessagesException.EMAIL_EMPTY);
            RuleFor(x => x.email).EmailAddress().WithMessage(ResourceMessagesException.EMAIL_INVALID);
            RuleFor(x => x.password.Length).GreaterThanOrEqualTo(6).WithMessage(ResourceMessagesException.PASSWORD_EMPTY);
        }
    }
}
