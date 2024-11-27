using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concreate;
using StoreApp.Web.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);
builder.Services.AddDbContext<StoreDbContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:StoreDbConnection"], b => b.MigrationsAssembly("StoreApp.Web"));
});

builder.Services.AddScoped<IStoreRepository, EfStoreRepository>();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("products_in_category","products/{category?}", new {controller="Home",action="Index"});
app.MapControllerRoute("products_details", "{name}", new {controler="Home",action="Details" });

app.MapDefaultControllerRoute();


app.Run();
