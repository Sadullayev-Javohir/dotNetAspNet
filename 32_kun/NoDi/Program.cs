public class EmailService
{
  public void Send(string m)
  {
    Console.WriteLine($"Email yuborildi: {m}");
  }
}

public class OrderService
{
  private readonly EmailService _emailService;

  public OrderService()
  {
    _emailService = new EmailService();
  }

  public void PlaceOrder(string product)
  {
    _emailService.Send(product);
  }
}

class Program
{
  static void Main()
  {
    var orderS = new OrderService();
    orderS.PlaceOrder("Laptop");
  }
}
