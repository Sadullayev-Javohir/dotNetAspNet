using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

class Program
{
  static void Main(string[] args)
  {
    Log.Logger = new LoggerConfiguration()
      .ReadFrom.Configuration(new ConfigurationBuilder()
      .AddJsonFile("appsettings.json")
      .Build())
    .CreateLogger();

    try
    {
      Log.Information("Dastur ishga tushdi");

      var host = CreateDefaultBuilder(args).Build();

      var userService = host.Services.GetRequiredService<UserService>();
    }
  }


}
