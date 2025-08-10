using FluentValidation;
using Project.Models;

public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
{
  public RegisterViewModelValidator()
  {
    RuleFor(x => x.FirstName)
      .NotEmpty().WithMessage("Ism kiritish majburiy")
      .Length(3, 50).WithMessage("Ism 3-50 belgi oralig'ida bo'lishi kerak"
    );

    RuleFor(x => x.Email)
      .NotEmpty().WithMessage("Email kiritish majburiy")
      .EmailAddress().WithMessage("Email formati noto'g'ri");

    RuleFor(x => x.Age)
      .InclusiveBetween(18, 60).WithMessage("Yosh 18-60 oralig'ida bo'lishi kerak");

    RuleFor(x => x.Phone)
      .Matches(@"^\+998\d{9}$").WithMessage("Telefon formati noto'g'ri");

    RuleFor(x => x.Password)
      .NotEmpty().WithMessage("Parol kiritish majburiy")
      .MinimumLength(6).WithMessage("Parol kamida 6 belgidan iborat bo'lishi kerak");

    RuleFor(x => x.ConfirmPassword)
      .Equal(x => x.Password).WithMessage("Paro l mos emas");
  }
}
