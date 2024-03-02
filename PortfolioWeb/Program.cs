using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using PortfolioWeb.Data.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Add MVC Controller
builder.Services.AddDbContext<PortfolioContext>(options =>{
    options.UseSqlite(builder.Configuration["ConnectionStrings:Sql_Connection"]);
});
 



var app = builder.Build();
app.UseStaticFiles();
SeedData.TestVerileriniDoldur(app);

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);
app.Run();
