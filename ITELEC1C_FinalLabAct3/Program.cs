using ITELEC1C_FinalLabAct3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
// Database Connection Service
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString"))
    //options => options.UseSqlServer("Server = DESKTOP-MR73GR0\\SQLEXPRESS; Database = ITELEC1C_FinalLabAct3_Ji; Trusted_connection = True; Encrypt = False")
    );

builder.Services.AddDefaultIdentity<User>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = true;
        options.Password.RequireNonAlphanumeric = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireLowercase = true;
        options.Password.RequiredLength = 8;
        options.User.RequireUniqueEmail = true;
    }).AddEntityFrameworkStores<AppDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
context.Database.EnsureCreated(); //create database if not exists

app.UseAuthentication();

app.UseAuthorization();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
