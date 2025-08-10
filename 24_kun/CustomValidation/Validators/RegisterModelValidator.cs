using FluentValidation;
using CustomValidation.Models;

namespace CustomValidation.Validators;

public class RegisterModelValidator : AbstractValidator<RegisterModel>
{
  public RegisterModelValidator()
  {
    RuleFor(x => x.Email)
    .NotEmpty().WithMessage("Email majburiy")
    .EmailAddress().WithMessage("Email formati noto'g'ri");

    RuleFor(x => x.Password)
      .NotEmpty().WithMessage("Parol majburiy")
      .MinimumLength(6).WithMessage("Kamida 6 belgidan iborat bo'lishi shart");

    RuleFor(x => x.ConfirmPassword)
      .Equal(x => x.Password).WithMessage("Parollar mos emas");
  }
}
