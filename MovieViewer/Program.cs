using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieViewer.Data;
using MovieViewer.Data.Entities;
using MovieViewer.Extensions;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

string connStr = builder.Configuration.GetConnectionString("LocalDb")!;

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FilmsDbContext>(opt => opt.UseSqlServer(connStr));

builder.Services.AddIdentity<User, IdentityRole>(
    options =>
        options.SignIn.RequireConfirmedAccount = false
    )
    .AddDefaultTokenProviders()
    .AddDefaultUI()
    .AddEntityFrameworkStores<FilmsDbContext>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;

    SeedExtensions.SeedRoles(serviceProvider).Wait();
    SeedExtensions.SeedAdmin(serviceProvider).Wait();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cart}/{action=Index}/{id?}");

app.Run();
