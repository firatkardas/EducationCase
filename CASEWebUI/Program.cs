using DataAccessLayer.Context;
using DataAccessLayer.Extentions;
using DataAccessLayer.Repositories.Abstractions;
using DataAccessLayer.Repositories.Concrete;
using DataAccessLayer.UnitOfworks;
using Microsoft.EntityFrameworkCore;
using ServicesLayer.Extentions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.LoadDataLayerExtention(builder.Configuration);
builder.Services.LoadServiceLayerExtention();

// Add services to the container.
builder.Services.AddControllersWithViews();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
