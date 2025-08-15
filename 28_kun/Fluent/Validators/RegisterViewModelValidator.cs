using FluentValidation;
using Fluent.Models;

namespace Fluent.Validators
{
  public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
  {
    public RegisterViewModelValidator()
    {
      RuleFor(x => x.FirstName)
        .NotEmpty().WithMessage("Ism majburiy")
        .Length(2, 50).WithMessage("Ism uzunligi 2-50 belgidan iborat bo'lishi kerak");

      RuleFor(x => x.LastName)
        .NotEmpty().WithMessage("Familya majburiy")
        .Length(2, 50).WithMessage("Familya uzunligi 2-50 bo'lishi kerak");

      RuleFor(x => x.Email)
        .NotEmpty().WithMessage("Email majburiy")
        .EmailAddress().WithMessage("Email formati noto'g'ri");

      RuleFor(x => x.Password)
        .NotEmpty().WithMessage("Parol majburiy")
        .MinimumLength(6).WithMessage("Parol kamida 6 belgidan iborat bo'lishi kerak")
        .Matches("[A-Z]").WithMessage("Parol kamida 1 ta katta harfdan iborat bo'lishi kerak")
        .Matches("[0-9]").WithMessage("Parol kamida 1 ta raqam bo'lishi kerak");

      RuleFor(x => x.ConfirmPassword)
        .Equal(x => x.Password).WithMessage("Parollar mos kelmadi");
    }
  }
}
