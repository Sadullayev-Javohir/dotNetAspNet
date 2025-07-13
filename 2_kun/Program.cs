// void Yoz (string matn, int son)
// {
//   Console.WriteLine($"{matn} - {son}");
// }

// Yoz(son: 5, matn : "Natija");


// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       ThrowException();
//     }
//     catch(Exception ex)
//     {
//       Console.WriteLine("Main catch block");
//       Console.WriteLine(ex);
//     }
//   }

//   static void ThrowException()
//   {
//     try
//     {
//       int x = 0;
//       int y = 5 /x;
//     }
//     catch(Exception)
//     {
//       throw;
//     }
//   }
// }


// class SalbiySonException : Exception
// {
//   public SalbiySonException(string xabar) : base(xabar) {}
// }

// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       Console.WriteLine("Iltimos, musbat son kiriting: ");
//       int son = int.Parse(Console.ReadLine());

//       if (son < 0)
//       {
//         throw new SalbiySonException("Xatolik: Son salbiy bo'lmasligi kerak");
//       }
//       Console.WriteLine($"Siz kiritgan son: {son}");
//     }
//     catch (SalbiySonException ex)
//     {
//       Console.WriteLine($"SalbiySonException: {ex.Message}");
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine($"Boshqa xatolik: {ex.Message}");
//     }
//   }
// }

// using System;
// using System.IO;

// class FaylIlova
// {
//   static void Main()
//   {
//     Console.Write("Fayl nomini kiriting: ");
//     string faylNomi = Console.ReadLine();

//     try
//     {
//       if (!File.Exists(faylNomi))
//       {
//         throw new FileNotFoundException("Fayl topilmadi");
//       }

//       string[] qatnashuvchilar = File.ReadAllLines(faylNomi);
//       Console.WriteLine("Fayldagi ma'lumotlar");

//       foreach (string s in qatnashuvchilar)
//       {
//         Console.WriteLine(s);
//       }
//     }
//     catch (FileNotFoundException ex)
//     {
//       Console.WriteLine($"Xatolik: {ex.Message}");
//     }
//     catch (IOException ex)
//     {
//       Console.WriteLine($"Fayl o'qish/yozish xatoligi: {ex.Message}");
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine($"Boshqa xatolik: {ex.Message}");
//     }
//     finally
//     {
//       Console.WriteLine("Faylga murojjat tugadi");
//     }
//   }
// }



// class BankHisobi
// {
//   public string Egasi { get; set; }
//   public decimal Balance { get; private set; }

//   public BankHisobi(string egasi, decimal boshlangichBalans)
//   {
//     Egasi = egasi;
//     Balance = boshlangichBalans;
//   }

//   public void PulYechish(decimal summa)
//   {
//     if (summa <= Balance)
//     {
//       Balance -= summa;
//     }
//     else
//     {
//       Console.WriteLine("Yetarli mablag' yo'q");
//     }
//   }

//   public void PulQosh(decimal summa)
//   {
//     Balance += summa;
//     Console.WriteLine($"{summa} so'm qo'shildi");
//   }

//   public void BalansniKorsat()
//   {
//     Console.WriteLine($"Joriy Balans: {Balance} so'm");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     BankHisobi hisob = new BankHisobi("Ali", 100000);
//     hisob.PulQosh(50000);
//     hisob.PulYechish(20000);
//     hisob.BalansniKorsat();
//   }
// }


// class Avtomobil
// {
//   public string Marka { get; set; }
//   public string Model { get; set; }
//   public int Yil { get; set; }
//   public decimal Narx { get; set; }

//   public Avtomobil(string Marka, string Model, int Yil, decimal Narx)
//   {
//     this.Marka = Marka;
//     this.Model = Model;
//     this.Yil = Yil;
//     this.Narx = Narx;
//   }

//   public void IshgaTushir()
//   {
//     Console.WriteLine($"{Marka} {Model} ishga tushdi");
//   }

//   public void Toxt()
//   {
//     Console.WriteLine($"{Marka} {Model} to'xtadi");
//   }

//   public void Malumot()
//   {
//     Console.WriteLine($"Marka: {Marka}, Model: {Model}, Yil: {Yil}, Narx: {Narx} so‘m");
//   }
// }


// class program
// {
//   static void Main()
//   {
//     List<Avtomobil> avtomobillar = new List<Avtomobil>();

//     avtomobillar.Add(new Avtomobil("Chevrolet", "Cobalt", 2022, 120))
//   }
// }

