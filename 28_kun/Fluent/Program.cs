using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Resources;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// 🔹 FluentValidation uchun o‘zbekcha LanguageManager
ValidatorOptions.Global.LanguageManager = new UzbekLanguageManager();

builder.Services.AddControllersWithViews()
    .AddFluentValidation(fv =>
    {
        fv.RegisterValidatorsFromAssemblyContaining<Fluent.Validators.RegisterViewModelValidator>();
    });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Register}/{id?}");

app.Run();
