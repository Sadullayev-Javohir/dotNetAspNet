// using System;
// using System.IO;

// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       string text = File.ReadAllText("file.txt");
//       Console.WriteLine(text);
//     }
//     catch (FileNotFoundException ex)
//     {
//       Console.WriteLine("Fayl topilmadi: " + ex.Message);
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine("Boshqa xatolik: " + ex.Message);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     using (FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate))
//     {
//       byte[] bytes = new byte[] { 1, 2, 3 };
//       fs.Write(bytes, 0, bytes.Length);
//     }
//     // string fullPath = Path.Combine("folder", "folder1", "file.txt");
//     // string extension = Path.GetExtension("file.txt");
//     // Console.WriteLine(extension);
//     // Directory.CreateDirectory("folder");
//     // Console.WriteLine("yaratildi");
//     // bool exists = Directory.Exists("folder");
//     // Console.WriteLine(exists);
//     // File.WriteAllText("file.txt", "Hello World");..
//   }
// }

class Program
{
  static void Main()
  {
    string path = "data.bin";

    // O'qish
    using (FileStream fs = new FileStream(path, FileMode.Open))
    {
      byte[] buffer = new byte[fs.Length];
      fs.Read(buffer, 0, buffer.Length);

      string result = System.Text.Encoding.UTF8.GetString(buffer);
      Console.WriteLine(result);
    }

    // Yozish
    using (FileStream fs = new FileStream(path, FileMode.Create))
    {
      byte[] data = { 72, 101, 108, 108, 111 };
      fs.Write(data, 0, data.Length);
    }
  }
}

// class Program
// {
//   static void Main()
//   {
//     using (StreamWriter sw = new StreamWriter("text.txt"))
//     {
//       sw.WriteLine("Hello World");
//     }
//     // using (StreamReader sr = new StreamReader("text.txt"))
//     // {
//     //   string? line;
//     //   while ((line = sr.ReadLine()) != null)
//     //   {
//     //     Console.WriteLine(line);
//     //   }
//     // }
//   }
// }

// string[] lines = File.ReadAllLines("text.txt");

// foreach (var line in lines)
// {
//   Console.WriteLine(line);
// }

// string[] content = { "Name,Age", "Ali,29", "Sara,22" };
// File.WriteAllLines("output.csv", content);


// var lines = File.ReadAllLines("output.csv");
// int count = lines.Length;
// Console.WriteLine("Yozuvlar soni: " + count);

// var lines = File.ReadAllLines("data.csv");

// foreach (var line in lines.Skip(1))
// {
//   var parts = line.Split(',');
//   Console.WriteLine($"Id: {parts[0]}, Name: {parts[1]}, Age: {parts[2]}");
// }

// List<string> newCsv = new List<string>();
// newCsv.Add("Name, Age");
// newCsv.Add("Ali, 25");
// newCsv.Add("Dina, 22");

// File.WriteAllLines("data1.csv", newCsv);

// using (StreamWriter sw = new StreamWriter("file.txt"))
// {
//   sw.Write("Dastur boshlandi");
//   sw.Write("Jarayon tugadi");
// }

// int lineCount = File.ReadAllLines("file.txt").Length;
// Console.WriteLine($"Satrolar soni: {lineCount}");


// using System.Text.Json;

// class Person
// {
//   public string? Name { get; set; }
//   public int Age { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     string json = "{\"Name\":\"Ali\",\"Age\":24}";

//     Person? person = JsonSerializer.Deserialize<Person>(json);
//     Console.WriteLine("Ism: " + person?.Name);
//     Console.WriteLine("Yosh: " + person?.Age);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // var person = new Person { Name = "Ali", Age = 24 };
//     // string json = JsonSerializer.Serialize(person);

//     // Person person = JsonSerializer.Deserialize<Person>(json);



//     // using (StreamWriter sw = new StreamWriter("file.txt"))
//     // {
//     //   sw.Write(json);
//     // }
//   }
// }


// using Newtonsoft.Json;
// class Person
// {
//   public string? Name { get; set; }
//   public int Age { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     var person = new Person { Name = "Ali", Age = 25 };
//     string json = JsonConvert.SerializeObject(person, Formatting.Indented);

//     Console.WriteLine(json);
//   }
// }

// using System.IO;
// using System.Xml.Serialization;

// public class Person
// {
//   public string? Name { get; set; }
//   public int Age { get; set; }
// }


// class Program
// {
//   static void Main()
//   {
//     var person = new Person { Name = "Ali", Age = 25 };
//     var serializer = new XmlSerializer(typeof(Person));
//     using (var writer = new StreamWriter("person.xml"))
//     {
//       serializer.Serialize(writer, person);
//     }
//   }
// }

// public class Person
// {
//   public string Name { get; set; }
//   public int Age { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     // var person = new Person { Name = "Ali", Age = 24 };
//     string json = "{\"Name\":\"Ali\",\"Age\":24}";
//     Person content = JsonSerializer.Deserialize<Person>(json);
//     Console.WriteLine(content.Name);
//     // var options = new JsonSerializerOptions
//     // {
//     //   WriteIndented = true,
//     //   PropertyNameCaseInsensitive = true
//     // };
//     // string json = JsonSerializer.Serialize(person);
//     // Console.WriteLine(json);

//     File.WriteAllText("file.txt", json);
//   }
// }
// public class Config
// {
//   public string? AppName { get; set; }
//   public int Version { get; set; }
//   public string[]? Authors { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     Config cfg;
//     var serializer = new XmlSerializer(typeof(Config));
//     using (var sr = new StreamReader("config.xml"))
//     {
//       cfg = (Config)serializer.Deserialize(sr);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
// Config cfg = new Config
// {
//   AppName = "MyApp",
//   Version = 1,
//   Authors = new[] { "Ali", "Vali", "Sami" }
// };

// string json = JsonSerializer.Serialize(cfg, new JsonSerializerOptions { WriteIndented = true });
// File.WriteAllText("config.json", json);

// string json = File.ReadAllText("config.json");

// Config? cfg = JsonSerializer.Deserialize<Config>(json);
// Console.WriteLine(cfg?.AppName);
// Console.WriteLine(cfg?.Version);
// var authors = cfg?.Authors;
// Console.WriteLine(String.Join(", ", authors));

//   }
// }

// using System.Text.Json;
// using System.Xml.Serialization;

// public class Person
// {
//   public string Name { get; set; }
//   public int Age { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     var serializer = new XmlSerializer(typeof(Person));

//     using (var reader = new StreamReader("person.xml"))
//     {
//       Person person = (Person)serializer.Deserialize(reader);
//       Console.WriteLine(person.Name);
//     }
//   }
// }
// class Program
// {
//   static void Main()
//   {
//     var person = new Person { Name = "Vali", Age = 21 };

//     var serializer = new XmlSerializer(typeof(Person));

//     using (var writer = new StreamWriter("person.xml"))
//     {
//       serializer.Serialize(writer, person);
//     }
//   }
// }
