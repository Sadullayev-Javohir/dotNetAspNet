using FluentValidation;

public class RegisterValidator : AbstractValidator<RegisterViewModel>
{
  public RegisterValidator()
  {
    RuleFor(x => x.FirstName)
      .NotEmpty().WithMessage("Ism majburiy")
      .MaximumLength(50);

    RuleFor(x => x.Email)
      .NotEmpty().WithMessage("Email majburiy")
      .EmailAddress().WithMessage("Noto'g'ri email format");

    RuleFor(x => x.Password)
      .NotEmpty().WithMessage("Email majburiy")
      .EmailAddress().WithMessage("Noto'g'ri email format");

    RuleFor(x => x.Password)
      .NotEmpty()
      .MinimumLength(6).WithMessage("Parol kamida 6 belgildan iborat bo'lishi kerak");

    RuleFor(x => x.ConfirmPassword)
      .Equal(x => x.Password).WithMessage("Parollar mos kelmadi");
  }
}
