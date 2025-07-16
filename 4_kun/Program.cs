// class Program
// {
//   static void ShowMessage(string msg)
//   {
//     Console.WriteLine("Xabar: " + msg);
//   }
//   static void Main()
//   {
//     Action<string> printer = ShowMessage;
//     printer("Bu action delegate");

//     Action greet = () => Console.WriteLine("Assalomu alaykum");
//     greet();
//   }
// }


// class Program
// {
//   static int Add(int a, int b)
//   {
//     return a + b;
//   }

//   static void Main()
//   {
//     Func<int, int, int> sumFunc = Add;
//     Console.WriteLine("Yig'indi: " + sumFunc(5, 4));

//     Func<int, int> square = x => x * x;
//     Console.WriteLine(square(5));
//   }
// }


// class Processor
// {
//   public static void PrintResult(int result)
//   {
//     Console.WriteLine("Natija: " + result);
//   }

//   public static void Compute(int a, int b, Func<int, int, int> operation, Action<int> callback)
//   {
//     int result = operation(a, b);
//     callback(result);
//   }

//   static void Main()
//   {
//     Func<int, int, int> multiply = (x, y) => x * y;
//     Func<int, int, int> add = (x, y) => x + y;

//     Console.Write("1-son: ");
//     int x = int.Parse(Console.ReadLine());

//     Console.Write("1-son: ");
//     int y = int.Parse(Console.ReadLine());

//     Compute(x, y, add, PrintResult);
//     Compute(x, y, multiply, result => Console.WriteLine("Ko'paytma " + result));
//   }
// }


// public class UserEventArgs : EventArgs
// {
//   public string Username { get; set; }
//   public DateTime Timestamp { get; set; }

//   public UserEventArgs(string username)
//   {
//     Username = username;
//     Timestamp = DateTime.Now;
//   }
// }

// public class Authenticator
// {
//   public event EventHandler<UserEventArgs> UserLoggedIn;
//   public event EventHandler<UserEventArgs> UserLoggedOut;

//   public void Login(string username)
//   {
//     Console.WriteLine($"{username} tizimga kirmoqda... ");
//     UserLoggedIn?.Invoke(this, new UserEventArgs(username));
//   }

//   public void LogOut(string username)
//   {
//     Console.WriteLine($"{username} tizimdan chiqilmoqda...");
//     UserLoggedIn?.Invoke(this, new UserEventArgs(username));
//   }
// }


// public class Logger
// {
//   public void OnUserLoggedIn(object sender, UserEventArgs e)
//   {
//     Console.WriteLine($"[LOG IN] {e.Username} | {e.Timestamp}");
//   }

//   public void OnUserLoggedOut(object sender, UserEventArgs e)
//   {
//     Console.WriteLine($"[LOG OUT] {e.Username} | {e.Timestamp}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Authenticator auth = new Authenticator();
//     Logger logger = new Logger();

//     auth.UserLoggedIn += logger.OnUserLoggedIn;
//     auth.UserLoggedOut += logger.OnUserLoggedOut;

//     auth.Login("Ali");
//     auth.LogOut("Ali");
//   }
// }



// public class OrderEventArgs : EventArgs
// {
//   public string OrderId { get; }
//   public string Status { get; }
//   public DateTime Time { get; }

//   public OrderEventArgs(string OrderId, string Status)
//   {
//     this.OrderId = OrderId;
//     this.Status = Status;
//     Time = DateTime.Now;
//   }
// }


// public class OrderService
// {
//   public event EventHandler<OrderEventArgs> OrderCreated;
//   public event EventHandler<OrderEventArgs> OrderShipped;
//   public event EventHandler<OrderEventArgs> OrderCancelled;

//   public void CreateOrder(string orderId)
//   {
//     Console.WriteLine($"Buyurtma yaratildi: {orderId}");
//     OrderCreated?.Invoke(this, new OrderEventArgs(orderId, "Created"));
//   }

//   public void ShipOrder(string orderId)
//   {
//     Console.WriteLine($"Buyurtma jo'natildi: {orderId}");
//     OrderShipped?.Invoke(this, new OrderEventArgs(orderId, "Shipped"));
//   }

//   public void CancelOrder(string orderId)
//   {
//     Console.WriteLine($"Buyurtma bekor qilindi: {orderId}");
//     OrderCancelled?.Invoke(this, new OrderEventArgs(orderId, "Cancelled"));
//   }
// }

// public class Logger
// {
//   public void Log(object sender, OrderEventArgs e)
//   {
//     Console.WriteLine($"[LOG] Order {e.OrderId} - {e.Status} @ {e.Time}");
//   }
// }


// public class Notifier
// {
//   public void Notify(object sender, OrderEventArgs e)
//   {
//     Console.WriteLine($"[EMAIL] Foydalanuvchiga xabar yuborildi: {e.Status}");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var OrderService = new OrderService();
//     var logger = new Logger();
//     var notifier = new Notifier();

//     OrderService.OrderCreated += logger.Log;
//     OrderService.OrderCreated += notifier.Notify;
//     OrderService.OrderShipped += logger.Log;
//     OrderService.OrderCancelled += logger.Log;
//     OrderService.CreateOrder("ORD-001");
//     OrderService.ShipOrder("ORD-001");
//     OrderService.CancelOrder("ORD-002");

//   }
// }

public interface IObserver
{
  void Update(string message);
}

interface ISubject
{
  void RegisterObserver(IObserver observer);
  void RemoveObserver(IObserver observer);
  void NotifyObservers(string message);
}

class NewsAgency : ISubject
{
  private List<IObserver> observers = new List<IObserver>();

  public void RegisterObserver(IObserver observer)
  {
    observers.Add(observer);
  }

  public void RemoveObserver(IObserver observer)
  {
    observers.Remove(observer);
  }

  public void NotifyObservers(string message)
  {
    foreach (var observer in observers)
    {
      observer.Update(message);
    }
  }

  public void PublishNews(string news)
  {
    Console.WriteLine("Yangi yangilik: " + news);
    NotifyObservers(news);
  }
}

class Subscriber : IObserver
{
  private string name;

  public Subscriber(string name)
  {
    this.name = name;
  }

  public void Update(string message)
  {
    Console.WriteLine($"{name} yangilikni oldi: {message}");
  }
}

class Program
{
  static void Main()
  {
    NewsAgency agency = new NewsAgency();

    Subscriber s1 = new Subscriber("Ali");
    Subscriber s2 = new Subscriber("VAli");

    agency.RegisterObserver(s1);
    agency.RegisterObserver(s2);

    agency.PublishNews("C# 13 chiqarildi!");

    agency.RemoveObserver(s1);

    agency.PublishNews("AI yangiliklari!");
  }
}


// using System.Collections.Generic;

// interface IObserver
// {
//   void Update(string message);
// }

// class NewsAgency
// {
//   private List<IObserver> observers = new List<IObserver>();

//   public void Subscribe(IObserver observer)
//   {
//     observers.Add(observer);
//   }

//   public void Publish(string news)
//   {
//     Console.WriteLine("Yangi yangillik: " + news);
//     foreach (var observer in observers)
//     {
//       observer.Update(news);
//     }
//   }
// }

// class Subscriber : IObserver
// {
//   private string name;
//   public Subscriber(string name)
//   {
//     this.name = name;
//   }

//   public void Update(string message)
//   {
//     Console.WriteLine($"{name} yangilikni oldi: {message}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     NewsAgency agency = new NewsAgency();

//     Subscriber ali = new Subscriber("Ali");
//     Subscriber laylo = new Subscriber("Laylo");

//     agency.Subscribe(ali);
//     agency.Subscribe(laylo);

//     agency.Publish("Ob havo ertaga yomg'irli bo'ladi");
//   }
// }
