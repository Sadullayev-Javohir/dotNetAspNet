// =============== CONTROLLER IJECTION =============
// public interface ILoggerService
// {
//     void Log(string message);
// }
//
// public class LoggerService : ILoggerService
// {
//     public void Log(string message) => Console.WriteLine(message);
// }
//
// public class UserService
// {
//     private readonly ILoggerService _loggerService;
//     public UserService(ILoggerService loggerService) => _loggerService = loggerService;
//
//     public void CreateUser() => _loggerService.Log("User yaratildi");
// }
//
// class Program
// {
//     static void Main()
//     {
//         var service = new UserService(new LoggerService());
//         service.CreateUser();
//     }
// }


// =============== PROPERTY IJECTION =============
// public interface IMessageSender
// { 
//     void Send(string message);
// }
//
// public class SmsService : IMessageSender
// {
//     public void Send(string message) => Console.WriteLine(message);
// }
//
// public class NotificationService
// {
//     public IMessageSender MessageSender { get; set; }
//     public void Notify() => MessageSender.Send("Salom");
// }
//
// class Program
// {
//     static void Main()
//     {
//         var service = new NotificationService();
//         service.MessageSender = new SmsService();
//         service.Notify();
//     }
// }

// =============== METHOD IJECTION =============
// public interface IPaymentService
// {
//     void Pay(decimal amount);
// }
//
// public class CardPaymentService : IPaymentService
// {
//     public void Pay(decimal amount) => Console.WriteLine($"To'lov: {amount}");
// }
//
// public class OrderService
// {
//     public void Checkout(IPaymentService paymentService) => paymentService.Pay(50000);
// }
//
// class Program
// {
//     static void Main()
//     {
//         var service = new OrderService();
//         service.Checkout(new CardPaymentService());
//     }
// }

