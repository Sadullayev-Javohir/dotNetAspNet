using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

// class Program
// {
//   public static async Task<string> GetMessage()
//   {
//     await Task.Delay(2000);
//     return "Hello, async world";
//   }

//   static async Task Main()
//   {
//     Console.WriteLine(await GetMessage());
//   }
// }


// class Program
// {
//   public static async Task<string> Download(string url)
//   {
//     using HttpClient client = new HttpClient();
//     string content = await client.GetStringAsync(url);
//     return content;
//   }

//   static async Task Main()
//   {
//     string url = "https://example.com";

//     try
//     {
//       string result = await Download(url);
//       Console.WriteLine("Yuklab olingan sahifa mazmuni: ");
//       Console.WriteLine(result);
//     }
//     catch(Exception ex)
//     {
//       Console.WriteLine($"Xatolik yuz berdi: {ex.Message}");
//     }
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     var urls = new List<string>
//     {
//       "https://example.com",
//       "https://learn.microsoft.com"
//     };

//     List<Task<string>> download = new List<Task<string>>();

//     foreach (var url in urls)
//     {
//       download.Add(DownloadPage(url));
//     }

//     string[] results = await Task.WhenAll(download);

//     for (int i = 0; i < urls.Count; i++)
//     {
//       Console.WriteLine($"[{urls[i]}] -> {results[i].Length}");
//     }
//   }

//   static async Task<string> DownloadPage(string url)
//   {
//     using HttpClient client = new HttpClient();
//     string content = await client.GetStringAsync(url);
//     return content;
//   }
// }


// class Program
// {
//   static async Task Main()
//   {

//     await Download("https://www.youtube.com/");
//   }
//   static async Task Download(string url)
//   {
//     using HttpClient client = new HttpClient();
//     string html = await client.GetStringAsync(url);
//     Console.WriteLine(html);
//   }
// }

// class Program
// {
//   static async Task ReadFile(string file)
//   {
//     string content = await File.ReadAllTextAsync(file);
//     Console.WriteLine($"Fayl uzunliigi: {content.Length} ta belgi bor");
//   }

//   static async Task Main()
//   {
//     await ReadFile("file.txt");
//   }
// }

// class Program
// {
//   static async Task Main()
//   {
//     var urls = new List<string>
//     {
//       "https://example.com",
//             "https://dotnet.microsoft.com",
//             "https://learn.microsoft.com"
//     };

//     List<Task<string>> download = new List<Task<string>>();

//     foreach (var url in urls)
//     {
//       download.Add(SafeDownload(url));
//     }

//     Task<string> first = await Task.WhenAny(download);
//     Console.WriteLine(await first);

//     string[] allResults = await Task.WhenAll(download);

//     Console.WriteLine("\n Barcha sahifalar yuklandi");
//     for (int i = 0; i < urls.Count; i++)
//     {
//       Console.WriteLine($"{urls[i]} -> {allResults[i]?.Length ?? 0} ta belgi ");
//     }

//   }
//   static async Task<string> SafeDownload(string url)
//   {
//     try
//     {
//       using HttpClient client = new HttpClient();
//       return await client.GetStringAsync(url);
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine($"Xatolik: {url} -> {ex.Message}");
//       return null;
//     }
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     var url = "https://example.com";
//     var httpClient = new HttpClient();

//     string content = await httpClient.GetStringAsync(url);

//     Console.WriteLine("Yuklangan ma'lumot uzunligi: " + content.Length);
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     var url = "https://www.google.com";
//     var httpClient = new HttpClient();
//     var cts = new CancellationTokenSource();

//     var download = httpClient.GetStringAsync(url, cts.Token);

//     cts.CancelAfter(19000);

//     try
//     {
//       string content = await download;
//       Console.WriteLine("Yuklnadi " + content.Length);
//     }
//     catch (TaskCanceledException)
//     {
//       Console.WriteLine("Yuklab olish bekor qilindi");
//     }
//   }
// }

// class Program
// {
//   static async Task Main()
//   {
//     var urls = new[]
//     {
//       "https://www.microsoft.com",
//             "https://www.example.com"
//     };

//     var client = new HttpClient();
//     var tasks = urls.Select(url => client.GetStringAsync(url));

//     var firstFinished = await Task.WhenAny(tasks);
//     string result = await firstFinished;

//     Console.WriteLine("Birinchi " + result.Length);

//   }
// }

class Program
{
  static async Task Main()
  {
    var urls = new[]
    {
      "https://example.com",
            "https://learn.microsoft.com"
    };

    var client = new HttpClient();

    var tasks = urls.Select(url => client.GetStringAsync(url));
    var results = await Task.WhenAll(tasks);

    for (int i = 0; i < urls.Length; i++)
    {
      Console.WriteLine($"{urls[i]} -> {results[i].Length} ta belgi");
    }
  }
}
