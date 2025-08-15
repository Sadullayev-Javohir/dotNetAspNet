using FluentValidation;
using Fluent2.Models;

namespace Fluent2.Validators;

public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
{
  public RegisterViewModelValidator()
  {
    RuleFor(x => x.FirstName)
      .NotEmpty().WithMessage("Ism majburiy")
      .Length(2, 50).WithMessage("Ism uzunligi 2-50 bo'lishi kerak");

    RuleFor(x => x.LastName)
      .NotEmpty().WithMessage("Familya majburiy")
      .Length(2, 50).WithMessage("Familya uzunligi 2-50 bo'lishi kerak");

    RuleFor(x => x.Email)
      .NotEmpty().WithMessage("Email majburiy")
      .EmailAddress().WithMessage("Email formati noto'g'ri");

    RuleFor(x => x.Password)
      .NotEmpty().WithMessage("Parol majburiy")
      .MinimumLength(6).WithMessage("Parol kamida 6 belgi bo'lishi kerak")
      .Matches(@"\p{Lu}").WithMessage("Parol kamida 1ta katta harf bo'lishi kerak")
      .Matches("[0-9]").WithMessage("Parol kamida 1ta raqam bo'lishi kerak");

    RuleFor(x => x.ConfirmPassword)
      .Equal(x => x.Password).WithMessage("Parollar mos kelmadi");
  }
}
