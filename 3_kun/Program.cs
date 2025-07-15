// // class Animal
// // {
// //   public void Eat()
// //   {
// //     Console.WriteLine("Animal is eating");
// //   }
// // }

// // class Dog : Animal
// // {
// //   public void Bark()
// //   {
// //     Console.WriteLine("Dog is barking");
// //   }
// // }

// // class Program
// // {
// //   static void Main()
// //   {
// //     var dog = new Dog();
// //     dog.Bark();
// //     dog.Eat();
// //   }
// // }


// class Animal
// {
//   protected string name;

//   protected void DisplayName()
//   {
//     Console.WriteLine("Name " + name);
//   }
// }

// class Cat : Animal
// {
//   public void ShowName()
//   {
//     name = "Mushuk";
//     DisplayName();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Cat cat = new Cat();
//     cat.ShowName();
//     cat.DisplayName();
//   }
// }


// class Animal
// {
//   protected string name;

//   public Animal(string name)
//   {
//     this.name = name;
//   }

//   public void Eat()
//   {
//     Console.WriteLine($"{name} is eating");
//   }
// }

// class Mammal : Animal
// {
//   public Mammal(string name) : base(name)
//   { }

//   public void Breathe()
//   {
//     Console.WriteLine($"{name} is breathing");
//   }
// }

// class Dog : Mammal
// {
//   public Dog(string name) : base(name)
//   { }
//   public void Bark()
//   {
//     Console.WriteLine($"{name} is barking");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Dog dog = new("Buddy");
//     dog.Eat();
//     dog.Breathe();
//     dog.Bark();
//   }
// }


// abstract class Shape
// {
//   public abstract double GetArea();
// }


// class Circle : Shape
// {
//   public double Radius { get; set; }

//   public Circle(double radius)
//   {
//     Radius = radius;
//   }

//   public override double GetArea()
//   {
//     return Math.PI * Radius * Radius;
//   }
// }

// class Rectangle : Shape
// {
//   public double Width { get; set; }
//   public double Height { get; set; }

//   public Rectangle(double Width, double Height)
//   {
//     this.Width = Width;
//     this.Height = Height;
//   }

//   public override double GetArea()
//   {
//     return Width * Height;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Shape[] shapes =
//     {
//       new Circle(5),
//       new Rectangle(4, 5)
//     };

//     foreach (var shape in shapes)
//     {
//       Console.WriteLine($"Area: {shape.GetArea()}");
//     }
//   }
// }



abstract class Transport
{
  public string name { get; set; }
  public Transport(string name)
  {
    this.name = name;
  }
  public abstract void StartEngine();
}

class Car : Transport
{
  public Car(string name) : base(name)
  { }
  public override void StartEngine()
  {
    Console.WriteLine($"{name} is starting engine ");
  }
}

class Bicycle : Transport
{
  public Bicycle(string name) : base(name)
  { }

  public override void StartEngine()
  {
    Console.WriteLine($"{name} is don't have engine");
  }
}

// class Bus : Transport
// {
//   public Bus(string name) : base(name) { }
//   public override void StartEngine()
//   {
//     Console.WriteLine($"{name} is engine slowed");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Transport[] transports =
//     {
//       new Car("malibu"),
//       new Bicycle("Nike"),
//       new Bus("Man")
//     };

//     foreach (var t in transports)
//     {
//       t.StartEngine();
//     }
//   }
// }


// interface IPay
// {
//   void PulYubor(decimal summa);
//   void QabulQilish(decimal summa);
// }

// class Plastic : IPay
// {
//   public void PulYubor(decimal summa)
//   {
//     Console.WriteLine($"{summa} yuborildi");
//   }
//   public void QabulQilish(decimal summa)
//   {
//     Console.WriteLine($"{summa} qabul qilindi");
//   }
// }

// class Naqd : IPay
// {
//   public void PulYubor(decimal summa)
//   {
//     Console.WriteLine($"{summa} yuborildi");
//   }
//   public void QabulQilish(decimal summa)
//   {
//     Console.WriteLine($"{summa} qabul qilindi");
//   }
// }


// class Elektron : IPay
// {
//   public void PulYubor(decimal summa)
//   {
//     Console.WriteLine($"{summa} yuborildi");
//   }
//   public void QabulQilish(decimal summa)
//   {
//     Console.WriteLine($"{summa} qabul qilindi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     List<IPay> bank = new List<IPay>()
//     {
//       new Plastic(),
//       new Naqd(),
//       new Elektron()
//     };
//     foreach (var b in bank)
//     {
//       b.PulYubor(2526);
//       b.QabulQilish(162778);
//     }
//   }
// }


// enum HaftaKuni
// {
//   Dushanba,
//   Seshanba,
//   Chorshanba,
//   Payshanba,
//   Juma,
//   Shanba,
//   Yakshanba
// }

// struct Point
// {
//   public int X;
//   public int Y;

//   public Point(int X, int Y)
//   {
//     this.X = X;
//     this.Y = Y;
//   }

//   public void Print()
//   {
//     Console.WriteLine($"Nuqta: {X}, {Y}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     HaftaKuni bugun = HaftaKuni.Juma;
//     Console.WriteLine($"Bugun: {bugun}");

//     Point p1 = new Point(3, 6);
//     p1.Print();
//   }
// }


// using System;

// enum Rang
// {
//   Qizil,
//   Yashil,
//   Moviy,
//   Sariq
// }

// struct Coordinate
// {
//   public int X;
//   public int Y;
//   public Rang Rang;

//   public Coordinate(int x, int y, Rang rang)
//   {
//     X = x;
//     Y = y;
//     Rang = rang;
//   }

//   public void ChopEt()
//   {
//     Console.WriteLine($"({X}, {Y}) - Rang: {Rang}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Coordinate c1 = new Coordinate(2, 4, Rang.Qizil);
//     Coordinate c2 = new Coordinate(6, 1, Rang.Yashil);
//     Coordinate c3 = new Coordinate(0, 0, Rang.Sariq);

//     c1.ChopEt();
//     c2.ChopEt();
//     c3.ChopEt();
//   }
// }


