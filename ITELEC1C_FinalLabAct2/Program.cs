using ITELEC1C_FinalLabAct2.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
// Database Connection Service
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString"))
<<<<<<< HEAD
    //options => options.UseSqlServer("Server = DESKTOP-MR73GR0\\SQLEXPRESS; Database = ITELEC1C_FinalLabAct2_Ji; Trusted_connection = True; Encrypt = False")
=======
    //options => options.UseSqlServer("Server = DESKTOP-MR73GR0\\SQLEXPRESS; Database = ITEELC1C_FinalLabAct2_Ji; Trusted_connection = True; Encrypt = False")
>>>>>>> 415a5c28324aca49abf8a6a22541d2ba0b2c35a2
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
context.Database.EnsureCreated(); //create database if not exists

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
