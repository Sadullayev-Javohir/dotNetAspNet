// using System;

// namespace dastur
// {
//   class Program
//   {
//     static void Main()
//     {
//       Console.Write("1-sonni kiriting: ");
//       double a = Convert.ToDouble(Console.ReadLine());

//       Console.Write("2-sonni kiriting: ");
//       double b = Convert.ToDouble(Console.ReadLine());

//       Console.Write("amalni kiriting(-,+,*,/): ");
//       string amal = Convert.ToString(Console.ReadLine());

//       switch (amal)
//       {
//         case "-": Console.WriteLine(a - b); break;
//         case "+": Console.WriteLine(a + b); break;
//         case "*": Console.WriteLine(a * b); break;
//         case "/":
//           Console.WriteLine((b != 0) ? a / b : "0 ga bo'lib bo'lmaydi");
//           break;
//         default:
//           Console.WriteLine("Xato");
//           break;
//       }
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Console.Write("Son kiriting: (string)");
//     string matn = Console.ReadLine();


//     int son;
//     double haqiqiy;
//     bool tugri;

//     if (int.TryParse(matn, out son))
//     {
//       Console.WriteLine("Butun son: {son}");
//     }
//     else
//     {
//       Console.WriteLine("Bu matnni songa aylantirib bo'lmaydi");
//     }

//     if (double.TryParse(matn, out haqiqiy))
//     {
//       Console.WriteLine($"Haqiqiy son: {haqiqiy}");
//     }

//     if (bool.TryParse(matn, out tugri))
//     {
//       Console.WriteLine($"Boolean qiymati: {tugri}");
//     }

//     Console.WriteLine($"To string: {son.ToString()}");
//   }
// }


// object qiymat = 5;

// if (qiymat is string x)
// {
//   Console.WriteLine(x);
// }


// class Program
// {
//   static void Main()
//   {
//     Console.Write("Nechta son kerak: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     int a = 0, b = 1;

//     Console.Write($"{a} {b} ");

//     for (int i = 2; i < n; i++)
//     {
//       int c = a + b;
//       Console.Write(c + " ");
//       a = b;
//       b = c;
//     }
//   }
// }


// class Program
// {
//   static int Fibonacci(int n)
//   {
//     if (n <= 1)
//     {
//       return n;
//     }
//     return Fibonacci(n - 1) + Fibonacci(n - 2);
//   }

//   static void Main()
//   {
//     Console.Write("Nechta son kerak: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     for (int i = 0; i < n; i++)
//     {
//       Console.Write($"{Fibonacci(i)} ");
//     }
//   }
// }


// LinkedList<string> navbat = new LinkedList<string>();
// navbat.AddLast("Ali");
// navbat.AddFirst("Zafar");
// foreach (var n in navbat)
// {
//   Console.WriteLine(n);
// }


// class Program
// {
//   static void Main()
//   {
//     List<int> sonlar = new List<int>() { 12, 5, 8, 3, 20 };

//     sonlar.Sort();
//     Console.WriteLine("Saralangan sonlar: ");
//     sonlar.ForEach(Console.WriteLine);

//     int izlanayotgan = 8;
//     if (sonlar.Contains(izlanayotgan))
//       Console.WriteLine("Topildi");
//     else
//       Console.WriteLine("Topilmadi");
//   }

// }


class Program
{
  static void Main()
  {
    Dictionary<int, string> talabalar = new Dictionary<int, string>();

    while (true)
    {
      Console.WriteLine("\n1. Qo‘shish\n2. O'chirish\n3. Qidirish\n4. Barcha talabalar\n5. Chiqish");
      Console.Write("Tanlang: ");
      string tanlov = Console.ReadLine();

      switch (tanlov)
      {
        case "1":
          Console.Write("Id kiriting: ");
          int id = Convert.ToInt32(Console.ReadLine());

          Console.Write("Ism kiriting: ");
          string ism = Console.ReadLine();

          if (!talabalar.ContainsKey(id))
          {
            talabalar.Add(id, ism);
          }
          else
          {
            Console.WriteLine("Bu id allaqachon mavjud");
          }
          break;
        case "2":
          Console.Write("O'chirish uchun Id: ");
          int deleteId = Convert.ToInt32(Console.ReadLine());
          talabalar.Remove(deleteId);
          break;
        case "3":
          Console.Write("Qidirilayotgan id: ");
          int searchId = Convert.ToInt32(Console.ReadLine());

          if (talabalar.ContainsKey(searchId))
            Console.WriteLine("Topildi: " + talabalar[searchId]);
          else
            Console.WriteLine("Topilmadi");
          break;

        case "4":
          Console.WriteLine("Talabalar ro'yxati: ");
          foreach (var t in talabalar)
          {
            Console.WriteLine($"{t.Key} : {t.Value}");
          }
          break;

        case "5":
          return;
        default:
          Console.WriteLine("Noto'g'ri tanlov");
          break;
      }
    }
  }
}
