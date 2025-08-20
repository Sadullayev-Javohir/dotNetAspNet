using Microsoft.Extensions.Logging;
using MyApp.Models;

public class UserService
{
  private readonly ILogger<UserService> _logger;

  public UserService(ILogger<UserService> logger)
  {
    _logger = logger;
  }

  public void Register(string username)
  {
    _logger.LogDebug("Register() chaqirilidi, username={Username}", username);

    if (string.IsNullOrWhiteSpace(username))
    {
      _logger.LogWarning("Foydalanuvchi nomi bo'sh");
      return;
    }

    var user = new User { Username = username };
    _logger.LogInformation("Foydalanuvchi ro'yxatdan o'tdi: {Username} ", user.Username);
  }
}
