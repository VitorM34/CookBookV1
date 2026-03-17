using FluentValidation;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Application.UseCases.User.Register;

public class RegisterUserValidator : AbstractValidator<RequestRegisterUserJson>    
{
    public RegisterUserValidator()
    {
        RuleFor(user => user.Name).NotEmpty();
        RuleFor(user => user.Email).NotEmpty();
        RuleFor(user => user.Email).EmailAddress();
        RuleFor(user => user.Password.Length).GreaterThanOrEqualTo(6);
}