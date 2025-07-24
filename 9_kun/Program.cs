// class Product
// {
//   public int Id { get; set; }
//   public string? Name { get; set; }
//   public string? Category { get; set; }
//   public double Price { get; set; }
// // }

// class Program
// {
//   static void Main()
//   {
//     List<Product> products = new()
//     {
//       new Product {Id = 1, Name = "Olma", Category = "Meva", Price = 5000},
//       new Product { Id = 2, Name = "Banan", Category = "Meva", Price = 8000 },
//       new Product { Id = 3, Name = "Sabzi", Category = "Sabzavot", Price = 3000 },
//       new Product { Id = 4, Name = "Kartoshka", Category = "Sabzavot", Price = 3500 },
//       new Product { Id = 5, Name = "Nok", Category = "Meva", Price = 6000 },
//     };

//     var qimmatlar = products.Where(p => p.Price > 4000).Select(p => p.Name).ToList();

//     var guruh = products.GroupBy(p => p.Category);

//     var engQimmat = products.OrderByDescending(p => p.Price).First();

//     double jamiNarx = products.Select(p => p.Price).Aggregate((a, b) => a + b);
//     Console.WriteLine(jamiNarx);
//     // Console.WriteLine(engQimmat.Name);
//     // foreach (var g in guruh)
//     // {
//     //   Console.WriteLine($"Kategoriya: {g.Key}");
//     //   foreach (var p in g)
//     //   {
//     //     Console.WriteLine($" - {p.Name} ({p.Price})");
//     //   }
//     // }
//     // Console.WriteLine(String.Join(",", qimmatlar));
//   }
// }


// using System;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main(string[] args)
//   {
//     ApiService api = new();
//     string result = await api.GetDataAsync();
//     Console.WriteLine("Api javobi: ");
//     Console.WriteLine(result);
//   }
// }
// public class ApiService
// {
//   private static readonly HttpClient _httpclient = new();

//   public async ValueTask<string> GetDataAsync()
//   {
//     try
//     {
//       string url = "https://jsonplaceholder.typicode.com/posts/1";
//       HttpResponseMessage response = await _httpclient.GetAsync(url);

//       response.EnsureSuccessStatusCode();

//       string responseBody = await response.Content.ReadAsStringAsync();
//       return responseBody;
//     }
//     catch (HttpRequestException ex)
//     {
//       Console.WriteLine("Http so'rovda xatolik" + ex.Message);
//       return $"Xatolik: {ex.Message}";
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine($"Noma'lum xatolik: {ex.Message}");
//       return $"Xatolik : {ex.Message}";
//     }
//   }
// }

// using System;
// using System.IO;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     string filePath = "data.txt";
//     string outputPath = "output.txt";

//     try
//     {
//       string content = await File.ReadAllTextAsync(filePath);

//       string upperContent = content.ToUpper();

//       await File.WriteAllTextAsync(outputPath, upperContent);
//       Console.WriteLine("Faylga yozildi");

//     }
//     catch (FileNotFoundException)
//     {
//       Console.WriteLine("Fayl topilmadi" + filePath);
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine("Xatolik " + ex.Message);
//     }
//   }
// }


// using System;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     using HttpClient client = new();

//     string url = "https://jsonplaceholder.typicode.com/posts/1";

//     string json = await client.GetStringAsync(url);

//     Console.WriteLine(json);
//   }
// }

// using System;
// using System.Net.Http;
// using System.Linq;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     using HttpClient client = new();

//     var urls = new[]
//     {
//       "https://jsonplaceholder.typicode.com/posts/1",
//             "https://jsonplaceholder.typicode.com/posts/2",
//             "https://jsonplaceholder.typicode.com/posts/3"
//     };

//     try
//     {
//       var tasks = urls.Select(url => client.GetStringAsync(url));

//       var results = await Task.WhenAll(tasks);

//       Console.WriteLine("✅ Api so'rovlar natijasi");
//       foreach (var r in results)
//       {
//         Console.WriteLine(r.Substring(0, 100));
//       }
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
//     }
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     using HttpClient client = new();
//     var urls = new[]
//   {
//       "https://jsonplaceholder.typicode.com/posts?userId=1",
//       "https://jsonplaceholder.typicode.com/posts?userId=2",
//       "https://jsonplaceholder.typicode.com/posts?userId=3",
//       "https://jsonplaceholder.typicode.com/posts?userId=4",
//       "https://jsonplaceholder.typicode.com/posts?userId=5",
//   };

//     var tasks = urls.Select(url => client.GetStringAsync(url));

//     var results = await Task.WhenAll(tasks);

//     foreach (var r in results)
//     {
//       Console.WriteLine(r);
//     }

//   }
// }

// class Program
// {
//   static void Main()
//   {
//     List<string> list = new() { "a", "b", "c" };
//     Parallel.ForEach(list, item =>
//     {
//       Console.WriteLine(item.ToUpper());
//     });
//   }
//   // static void Main()
//   // {
//   //   Parallel.For(0, 10, i =>
//   //   {
//   //     Console.WriteLine(i);
//   //   });
//   // }
//   // static Task t = Task.Run(() =>
//   // {
//   //   Console.WriteLine("Task ishlayapti");
//   // });

//   // static async Task Main()
//   // {
//   //   await t;
//   // }
// }


// class Program
// {
//   static async Task Main()
//   {

//     // List<int> numbers = new List<int>() { 1, 3, 4, 5, 6, 7, 8, 9, 10 };

//     // var result = numbers.AsParallel().Where(n => n % 2 == 0).Select(n => n * 2).ToList();

//     // Console.WriteLine(String.Join(", ", numbers));

//     // ThreadPool.QueueUserWorkItem(_ =>
//     // {
//     //   Console.WriteLine("ThreadPool ishlayapti");
//     // });

//     // var tasks = new List<Task>
//     // {
//     //   Task.Delay(1000),
//     //   Task.Delay(3000),
//     //   Task.Delay(500),
//     // };
//     // await Task.WhenAll(tasks);
//     // Console.WriteLine("Bajarildi");
//   }
// }

using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Png;

class Program
{
  static void Main()
  {
    string inputPath = "rasm.png";
    string outputDir = "output";
    string outputPath = Path.Combine(outputDir, "rasm2.png");

    try
    {
      if (!Directory.Exists(outputDir))
      {
        Directory.CreateDirectory(outputDir);
      }

      using (Image image = Image.Load(inputPath))
      {
        image.Mutate(x => x
        .Resize(300, 300)
        .Grayscale());
        image.Save(outputPath, new PngEncoder());
      }
      Console.WriteLine("Rasm png formatda saqlandi");
    }
    catch (Exception ex)
    {
      Console.WriteLine("Xatolik: " + ex.Message);
    }
  }
}
