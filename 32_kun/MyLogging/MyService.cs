using Microsoft.Extensions.Logging;
using System;

public class MyService
{
  private readonly ILogger<MyService> _logger;

  public MyService(ILogger<MyService> logger)
  {
    _logger = logger;
  }

  public void Run()
  {
    _logger.LogTrace("Run() metodi ishga tushdi");
    _logger.LogInformation("MyService ishlayapti...");

    int x = 10, y = 0;

    _logger.LogInformation("Hisoblash boshlanmoqda: x={x}, y={y}", x, y);

    try
    {
      if (y == 0)
      {
        _logger.LogWarning("Bo‘linuvchi y=0, nolga bo‘linish xatoligi bo‘lishi mumkin!");
      }

      int res = x / y; // DivideByZeroException
    }
    catch (Exception ex)
    {
      _logger.LogError(ex, "Hisoblashda xatolik yuz berdi");
      _logger.LogCritical("Jiddiy xato yuz berdi, servis to‘xtashi mumkin!");
    }
  }
}
