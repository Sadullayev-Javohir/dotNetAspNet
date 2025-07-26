using System.Text.Json;

class Person
{
  public string? Name { get; set; }
  public int Age { get; set; }
}

class Program
{
  static void Main()
  {
    var person = new Person() { Name = "Ali", Age = 24 };

    var json = JsonSerializer.Serialize(person);


    Person? deserialize = JsonSerializer.Deserialize<Person>(json);
    Console.WriteLine(deserialize?.Name);
    // Console.WriteLine(json);
  }
}


// using Newtonsoft.Json;
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
//     var person = new Person { Name = "Ali", Age = 24 };

//     string xml;

//     var serializer = new XmlSerializer(typeof(Person));

//     using (StringWriter writer = new StringWriter())
//     {
//       serializer.Serialize(writer, person);
//       xml = writer.ToString();
//       // Console.WriteLine(xml);
//     }

//     using (StringReader reader = new StringReader(xml))
//     {
//       Person deserialized = (Person?)serializer.Deserialize(reader);
//       Console.WriteLine(deserialized.Name);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var person = new Person { Name = "Ali", Age = 24 };

//     var json = JsonConvert.SerializeObject(person);

//     Person? deserialize = JsonConvert.DeserializeObject<Person>(json);
//     Console.WriteLine(deserialize?.Name);
//     // Console.WriteLine(json);
//   }
// }


// using System.Text.Json;
// public class Config
// {
//   public string? AppName { get; set; }
//   public string? Version { get; set; }
//   public bool IsDarkMode { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     string path = "config.json";

//     if (File.Exists(path))
//     {
//       string json = File.ReadAllText(path);
//       Config? config = JsonSerializer.Deserialize<Config>(json);
//       Console.WriteLine($"AppName: {config?.AppName}, Version: {config?.Version}, IsDarkMode: {config?.IsDarkMode}");

//       config.IsDarkMode = !config.IsDarkMode;

//       string updateJson = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
//       File.WriteAllText(path, updateJson);
//     }
//     else
//     {
//       var config = new Config
//       {
//         AppName = "MyApp",
//         Version = "1.0",
//         IsDarkMode = false,
//       };

//       string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
//       File.WriteAllText(path, json);
//     }
//   }
// }


// public static class StringExtension
// {
//   public static bool IsNullOrEmpty(this string str)
//   {
//     return string.IsNullOrEmpty(str);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     string name = "";
//     Console.WriteLine(name.IsNullOrEmpty());
//   }
// }




// class Program
// {
//   static void Main()
//   {
// (string, int) GetUser()
// {
//   return ("Ali", 25);
// }

// var (name, age) = GetUser();
// Console.WriteLine($"{name} {age}");

// (string Name, int Age) GetUser()
// {
//   return ("Ali", 25);
// }

// var user = GetUser();
// Console.WriteLine(user.Name);

// object obj = "iog";
// PrintType(obj);




//   }

//   static void PrintType(object o)
//   {
//     switch (o)
//     {
//       case int i:
//         Console.WriteLine($"Integer: {i}");
//         break;
//       case string s when s.Length > 5:
//         Console.WriteLine("Long string");
//         break;
//       default:
//         Console.WriteLine("Unknown");
//         break;
//     }
//   }
// }


// public record Person(string Name, int Age);

// class Program
// {
//   static void Main()
//   {
//     var p1 = new Person("Ali", 235);
//     var p2 = p1 with { Age = 25 };
//     Console.WriteLine(p1);
//     Console.WriteLine(p2);
//   }
// }

// public static class StringExtensions
// {
//   public static string ToTitleCase(this string input)
//   {
//     if (string.IsNullOrWhiteSpace(input)) return input;

//     return string.Join("", input.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     string title = "salom dunyo";
//     Console.WriteLine(title.ToTitleCase());
//   }
// }

// public static class ListExtensions
// {
//   public static void Shuffle<T>(this List<T> list)
//   {
//     Random rng = new Random();
//     int n = list.Count;

//     while (n > 1)
//     {
//       int k = rng.Next(n--);
//       (list[n], list[k]) = (list[k], list[n]);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//     numbers.Shuffle();
//     Console.WriteLine(string.Join(", ", numbers));
//   }
// }
