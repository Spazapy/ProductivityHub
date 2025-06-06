using Microsoft.EntityFrameworkCore;
using ProductivityHub.Models.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProductivityHubDataBase>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductivityDataBase")) );

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();