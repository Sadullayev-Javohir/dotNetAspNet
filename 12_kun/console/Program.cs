// using System.Text;
// public class LogService
// {
//   public void CreateLog()
//   {
//     var sb = new StringBuilder();
//     for (int i = 0; i < 1_000_000; i++)
//     {
//       sb.AppendLine($"Log {i}");
//     }

//     string log = sb.ToString();
//     File.WriteAllText("log.txt", log);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     LogService logservice = new LogService();

//     logservice.CreateLog();

//     Console.WriteLine("Log yozildi");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // int[] numbers = { 1, 2, 3, 4, 5, 6 };
//     // Span<int> slice = numbers.Slice(0, 3);
//     // slice[2] = 152;
//     // Console.WriteLine(String.Join(",", numbers));

//     // var span = new Span<int>(new int[] { 1, 2, 3, 4, 5, 6 });
//     // var sub = span.Slice(1, 3);
//     // Console.WriteLine(String.Join(", ", span.ToArray()));

//     // Span<int> span = new int[5];
//     // span.Fill(42);
//     // span.Clear();
//     // Console.WriteLine(String.Join(", ", span.ToArray()));
//     // ReadOnlySpan<char> input = "Hello World".AsSpan();

//     // for (int i = 0; i < input.Length; i++)
//     // {
//     //   Console.WriteLine(input[i]);
//     // }

//     // string text = "Salom";
//     // ReadOnlySpan<char> span = text.AsSpan();
//     // Console.WriteLine(new string(span));

//     // Memory<int> numbers = new int[] { 10, 20, 30, 40, 50 };

//     // Span<int> span = numbers.Span;
//     // span[0] = 99;
//     // Console.WriteLine(String.Join(", ", numbers.ToArray()));

//     Memory<byte> buffer = new byte[10];

//     Memory<byte> slice = buffer.Slice(2, 4);

//     slice.Span[0] = 100;
//     slice.Span[1] = 101;

//     Console.WriteLine(String.Join(", ", buffer.ToArray()));
//   }
// }

// class Program
// {
//   static async Task Main()
//   {
//     Memory<byte> buffer = new byte[100];

//     new Random().NextBytes(buffer.Span);

//     await SaveToFileAsync("output.bin", buffer);
//     Console.WriteLine("Faylga yozildi");
//   }

//   static async Task SaveToFileAsync(string path, Memory<Byte> data)
//   {
//     using var stream = new FileStream(path, FileMode.Create, FileAccess.Write);
//     await stream.WriteAsync(data);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     string text = "Assalomu alaykum";
//     ReadOnlyMemory<char> mem = text.AsMemory();

//     var salom = mem.Slice(0, 8);
//     var qolgani = mem.Slice(9);

//     Console.WriteLine(new string(salom.Span));
//     Console.WriteLine(new string(qolgani.Span));


//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // Span<byte> buffer = new byte[128];
//     // for (int i = 0; i < buffer.Length; i++)
//     // {
//     //   buffer[i] = (byte)i;
//     // }
//     // Console.WriteLine(buffer[0]);
//     // Console.WriteLine(buffer[126]);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int[] bigArray = Enumerable.Range(1, 1000000).ToArray();

//     Span<int> midSection = bigArray.AsSpan(500_000, 100);

//     for (int i = 0; i < midSection.Length; i++)
//     {
//       midSection[i] *= 2;
//     }
//     Console.WriteLine(String.Join(", ", bigArray.ToArray()));
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Random rnd = new Random();
//     // int son = rnd.Next(1, 101);
//     double son = rnd.NextDouble();
//     Console.WriteLine(son);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Span<char> buffer = stackalloc char[50];
//     "Hello World".AsSpan().ToUpperInvariant(buffer);
//     Console.WriteLine(buffer.Slice(0, 11).ToString());
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     using var memoryOwner = MemoryPool<byte>.Shared.Rent(1024);
//     Memory<byte> buffer = memoryOwner.Memory;
//   }
// }
