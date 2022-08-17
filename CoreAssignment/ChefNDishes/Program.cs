// Additional libraries
using ChefNDishes.Models;
using Microsoft.EntityFrameworkCore;
// Creates builder (also part of boilerplate code for web apps)
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
//  Creates the db connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); 
// Adds database connection - must be before app.Build();
builder.Services.AddDbContext<ChefNDishesContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

