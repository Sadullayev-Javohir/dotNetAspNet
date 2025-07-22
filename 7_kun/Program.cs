// class Program
// {
//   enum WeekDay
//   {
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday,
//     Sunday,
//     Saturday,
//   }

//   static void Main()
//   {
//     WeekDay day = WeekDay.Monday;
//     Console.WriteLine((int)day);
//   }
// }

// public class Box<T>
// {
//   public T? Value;

//   public void SetValue(T val)
//   {
//     Value = val;
//   }

//   public T GetValue()
//   {
//     return Value;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Box<int> intBox = new Box<int>();
//     intBox.SetValue(10);

//     Box<string> strBox = new Box<string>();
//     strBox.SetValue("Salom");
//     Console.WriteLine(strBox.GetValue());
//   }
// }


// public class RefTypeBox<T> where T : class
// {
//   public T? Value { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     RefTypeBox<string> stringbox = new RefTypeBox<string> { Value = "Name" };
//   }
// }
// public class ValueType<T> where T : struct
// {
//   public T Value { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     ValueType<int> valuet = new ValueType<int>() {Value = 4};
//   }
// }

// public class Creator<T> where T : new()
// {
//   public T CreateInstance()
//   {
//     return new T();
//   }
// }

// public class Person
// {
//   public string Name = "Anonim";
// }

// class Program
// {
//   static void Main()
//   {
//     Creator<Person> creator = new Creator<Person>();
//     Person p = creator.CreateInstance();
//   }
// }

// public class BaseClass
// {
//   public virtual string GetName() => "Base";
// }

// public class Derived : BaseClass
// {
//   public override string GetName() => "Derrived";
// }

// public class BaseProcessor<T> where T : BaseClass
// {
//   public void PrintName(T item)
//   {
//     Console.WriteLine(item.GetName());
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     BaseProcessor<Derived> derived = new BaseProcessor<Derived>();
//     derived.PrintName(new Derived());
//   }
// }


// public interface IPrintable
// {
//   void Print();
// }

// public class PrintableClass : IPrintable
// {
//   public void Print()
//   {
//     Console.WriteLine("Printing...");
//   }
// }

// public class Printer<T> where T : IPrintable
// {
//   public void PrintItem(T item)
//   {
//     item.Print();
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Printer<PrintableClass> printer = new Printer<PrintableClass>();
//     printer.PrintItem(new PrintableClass());
//   }
// }


// public class Almash
// {
//   public static void Swap<T>(ref T a, ref T b)
//   {
//     T temp = a;
//     a = b;
//     b = temp;
//   }
//   static void Main()
//   {
//     int x = 4, y = 5;
//     Swap<int>(ref x, ref y);

//     Console.WriteLine(x + " " + y);
//   }
// }


using System;
using System.Collections.Generic;
using System.Linq;

public interface IEntity
{
  int Id { get; set; }
}

public class Repository<T> where T : class, IEntity
{
  private List<T> items = new List<T>();

  public void Add(T item)
  {
    items.Add(item);
  }

  public IEnumerable<T> GetAll()
  {
    return items;
  }

  public T Find(int id)
  {
    return items.FirstOrDefault(x => x.Id == id);
  }

  public void Remove(int id)
  {
    var item = Find(id);
    if (item != null)
      items.Remove(item);
  }
}

public class Student : IEntity
{
  public int Id { get; set; }
  public string Name { get; set; }
}

class Program
{
  static void Main()
  {
    Repository<Student> studentRepo = new Repository<Student>();
    studentRepo.Add(new Student { Id = 1, Name = "Ali" });
    studentRepo.Add(new Student { Id = 2, Name = "Laylo" });

    foreach (var s in studentRepo.GetAll())
    {
      Console.WriteLine($"{s.Id} : {s.Name}");
    }
    studentRepo.Remove(1);
    foreach (var s in studentRepo.GetAll())
    {
      Console.WriteLine($"{s.Id} : {s.Name}");
    }
  }
}
