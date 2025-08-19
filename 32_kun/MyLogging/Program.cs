using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

      var host = CreateHostBuilder(args).Build();

      // 🔥 MyService ni olish va ishlatish
      var service = host.Services.GetRequiredService<MyService>();
      service.Run();

      host.Run();
    }
    catch (Exception ex)
    {
      Log.Fatal(ex, "Dasturda xatolik yuz berdi");
    }
    finally
    {
      Log.CloseAndFlush();
    }
  }

  static IHostBuilder CreateHostBuilder(string[] args) =>
      Host.CreateDefaultBuilder(args)
          .UseSerilog()
          .ConfigureServices((context, services) =>
          {
            services.AddSingleton<MyService>();
          });
}
