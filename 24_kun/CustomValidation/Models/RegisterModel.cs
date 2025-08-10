namespace CustomValidation.Models;

public class RegisterModel
{
  public string Email { get; set; }
  public string Password { get; set; } = string.Empty;
  public string ConfirmPassword { get; set; } = string.Empty;
}
