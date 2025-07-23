// public interface IId
// {
//   public int Id { get; set; }
// }
// public class Repository<T> where T : class, IId
// {
//   private List<T> items = new List<T>();

//   public void Add(T item)
//   {
//     if (!items.Contains(item))
//     {
//       items.Add(item);
//       Console.WriteLine("Qo'shildi");
//     }
//     else
//     {
//       Console.WriteLine("Bu id bor");
//     }
//   }

//   public IEnumerable<T> GetAll()
//   {
//     Console.WriteLine("Hammasi olindi: ");
//     return items;
//   }

//   public T Find(int id)
//   {
//     return items.FirstOrDefault(x => x.Id == id);
//   }

//   public void Remove(int id)
//   {
//     var item = Find(id);
//     if (item != null)
//     {
//       items.Remove(item);
//     }
//   }
// }

// class Student : IId
// {
//   public int Id { get; set; }
//   public string Name { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     Repository<Student> studentRepo = new Repository<Student>();

//     studentRepo.Add(new Student { Id = 1, Name = "Ali" });
//     studentRepo.Add(new Student { Id = 2, Name = "Vali" });
//     var students = studentRepo.GetAll();
//     foreach (var s in students)
//     {
//       Console.WriteLine(s.Name + " " + s.Id);
//     }
//   }
// }


// public delegate void Delegate(string message);

// class Program
// {
//   static void ShowMessage(string msg)
//   {
//     Console.WriteLine(msg);
//   }
//   static void Main()
//   {
//     Delegate deleg = ShowMessage;
//     deleg("Salom");
//   }
// }


// public delegate void MyEventHandler();

// class Notifier
// {
//   public event MyEventHandler OnNotify;

//   public void TriggerEvent()
//   {
//     Console.WriteLine("Event chaqirildi");
//     OnNotify?.Invoke();
//   }
// }

// public class Listener
// {
//   public void HandleNotification()
//   {
//     Console.WriteLine("Hodisani Listener qabul qildi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Notifier notifier = new Notifier();
//     Listener listener = new Listener();

//     notifier.OnNotify += listener.HandleNotification;

//     notifier.TriggerEvent();
//   }
// }
// public class MyEventArgs : EventArgs
// {
//   public string Message { get; set; }
// }

// class Notifier
// {
//   public event EventHandler<MyEventArgs> OnNotify;

//   public void Trigger()
//   {
//     Console.WriteLine("Yuborilmoqda");
//     OnNotify?.Invoke(this, new MyEventArgs { Message = "Xabarnoma yuborildi" });
//   }
// }

// class Listener
// {
//   public void Receiver(object sender, MyEventArgs e)
//   {
//     Console.WriteLine("Qabul qilindi");
//     Console.WriteLine(e.Message);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Notifier n = new Notifier();
//     Listener l = new Listener();

//     n.OnNotify += l.Receiver;
//     n.Trigger();

//   }
// }


// Action<string> print = msg => Console.WriteLine(msg);

// print("Salom");


// Func<int, int, int> sum = (a, b) => a + b;
// Console.WriteLine(sum(54, 56));

// Predicate<int> isEven = num => num % 2 == 0;
// Console.WriteLine(isEven(4));

public class XabarEventArgs : EventArgs
{
  public string Matn { get; set; }
}

public class Xabar
{
  public event EventHandler<XabarEventArgs> XabarHandler;

  public void Yubor(string matn)
  {
    Console.WriteLine($"[Yuboruvchi] yuborilmoqda: {matn}");
    XabarHandler?.Invoke(this, new XabarEventArgs { Matn = matn });
  }
}

public class EmailQabul
{
  public void Qabul(object sender, XabarEventArgs e)
  {
    Console.WriteLine("[Email] qabul qilindi " + e.Matn);
  }
}

public class SmsQabul
{
  public void Qabul(object sender, XabarEventArgs e)
  {
    Console.WriteLine("[Sms] qabul qilindi " + e.Matn);
  }
}

class Program
{
  static void Main()
  {
    Xabar xabar = new Xabar();
    EmailQabul email = new EmailQabul();
    SmsQabul sms = new SmsQabul();

    xabar.XabarHandler += email.Qabul;
    xabar.XabarHandler += sms.Qabul;

    xabar.Yubor("Bu test xabari");
  }
}

// Func<int, int, int> yigindi = (a, b) => a + b;
// Console.WriteLine(yigindi(3, 6));

// Action<string> chiqar = x => Console.WriteLine(x);
// chiqar("35");

// var sonlar = new List<int>() { 114, 25, 2, 6, 2, 75, 3 };

// var natija = sonlar.Where(x => x > 10);
// Console.WriteLine(String.Join(", ", natija));

