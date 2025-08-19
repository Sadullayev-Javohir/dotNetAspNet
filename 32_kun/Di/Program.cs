using Microsoft.Extensions.DependencyInjection;


public interface INotificationService
{
  public void Send(string message);
}

public class EmailService : INotificationService
{
  public void Send(string m)
  {
    Console.WriteLine("Email yuborildi " + m);
  }
}

public class SmsService : INotificationService
{
  public void Send(string m)
  {
    Console.WriteLine("Sms yuborildi " + m);
  }
}

public class OrderService
{
  private readonly INotificationService _notification;

  public OrderService(INotificationService notification)
  {
    _notification = notification;
  }

  public void PlaceOrder(string product)
  {
    _notification.Send($"Buyurtma qabul qilindi:  {product}");
  }
}

class Program
{
  static void Main()
  {
    var services = new ServiceCollection();

    services.AddScoped<INotificationService, EmailService>();
    services.AddScoped<OrderService>();

    var serviceProvider = services.BuildServiceProvider();

    var orderService = serviceProvider.GetRequiredService<OrderService>();
    orderService.PlaceOrder("Laptop");
  }
}
