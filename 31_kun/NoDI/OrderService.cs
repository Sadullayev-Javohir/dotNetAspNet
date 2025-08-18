namespace NoDI;

public class OrderService
{
  private readonly EmailService _emailService;

  public OrderService()
  {
    _emailService = new EmailService();
  }

  public void PlaceOrder(string product)
  {
    _emailService.Send($"Buyurtma qabul qilindi: {product}");
  }
}

