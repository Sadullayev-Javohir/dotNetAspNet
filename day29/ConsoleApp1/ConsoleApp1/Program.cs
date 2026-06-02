using ConsoleApp1.Data;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

string connectionString = configuration.GetConnectionString("DefaultConnection")!;

var options = new DbContextOptionsBuilder<AppDbContext>().UseNpgsql(connectionString).Options;

using var db = new AppDbContext(options);

Console.WriteLine("Database Connected");

// db.Users.Add(new User
// {
//    Name = "Ali",
//    Email = "ali@gmail.com"
// });
// db.SaveChanges();
// Console.WriteLine("User saqlandi");



// var user = db.Users.Find(1);
// user.Name = "Vali";
// db.SaveChanges();
// Console.WriteLine("Db yangilandi");

var users = db.Users.ToList();

foreach (var user in users)
{
   Console.WriteLine($"{user.Id} - {user.Name} - {user.Email}");
}
