// class Program
// {
//   static void Main()
//   {
//     string name = null;
//     string displayName = name ?? "Guest";
//     Console.WriteLine(displayName);
//   }
// }
// class Person
// {
//   public string Name { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     Person person = null;
//     Console.WriteLine(person?.Name);
//     int? length = person?.Name?.Length;
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // string name = null;
//     // name ??= "Anonim";

//     // Console.WriteLine(name);

//     string? name = null;

//     if (name != null)
//     {
//       Console.WriteLine(name.Length);
//     }
//   }
// }


// public class Person
// {
//   public string? Name { get; set; }
//   public Address? Address { get; set; }
// }

// public class Address
// {
//   public string? City { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     // Person person = new Person();
//     // string city = person.Address?.City ?? "Noma'lum";
//     // Console.WriteLine(city);
//     // int? x = null;
//     // Console.WriteLine(x.HasValue);
//     // string? text = null;
//     // int? length = text?.Length;
//     // Console.WriteLine(length);

//     int? number = null;
//     int? value = number;



//   }
// }

// class Program
// {
//   static string? GetString(bool say)
//   {
//     if (say)
//     {
//       return "Salome";
//     }
//     else
//     {
//       return null;
//     }
//   }
//   static void Main()
//   {
//     var result = GetString(false);
//     Console.WriteLine(result ?? "Hech narsa yo'q");
//   }
// }

// class Program
// {
//   static int? GetAge(bool hasAge)
//   {
//     if (hasAge)
//     {
//       return 25;
//     }
//     else
//     {
//       return null;
//     }
//   }
//   static void Main()
//   {
//     int? age = GetAge(false);
//     Console.WriteLine(age ?? -1);
//   }
// }

// class Person
// {
//   public string Name { get; set; }
// }

// public class Program
// {
//   static void Main()
//   {
//     Person? person = null;
//     // person.Name = "Javohir";
//     // if (person != null)
//     // {
//     //   Console.WriteLine(person.Name);
//     // }
//     person ??= new Person();
//   }
// }


// abstract class Shape {}

// class Circle : Shape
// {
//   public double Radius { get; set; }
// }

// class Rectangle : Shape
// {
//   public double Width { get; set; }
//   public double Height { get; set; }
// }

// class Triangle : Shape
// {
//   public double Base { get; set; }
//   public double Height { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     double CalculateArea(Shape shape) => shape switch
//     {
//       Circle c => Math.PI * c.Radius * c.Radius,
//       Rectangle r => r.Width * r.Height,
//       Triangle t => 0.5 * t.Base * t.Height,
//       _ => throw new ArgumentException("Noma'lum shakl")
//     };

//     Shape shape = new Circle { Radius = 5 };
//     Console.WriteLine(CalculateArea(shape));
//   }
// }

namespace SALARY
{
  class Employee
  {
    public string? Name { get; set; }
    public decimal Salary { get; set; }
  }

  class Program
  {
    static string ClassicSalary(Employee emp) => emp.Salary switch
    {
      < 300m => "Past daraja",
      >= 300m and < 1000m => "O'rtacha daraja",
      >= 1000m => "Yuqori daraja"
    };
    static void Main()
    {
      var emp = new Employee { Name = "Ali", Salary = 950m };
      Console.WriteLine(ClassicSalary(emp));
    }
  }
}

// class Program
// {
//   static void Main()
//   {
//     int narx = 401;

//     if (narx is > 400 and < 490)
//     {
//       Console.WriteLine("oraliqda");
//     }
//   }
// }

