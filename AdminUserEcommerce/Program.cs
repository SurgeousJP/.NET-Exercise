using AdminUserEcommerce.Models;
using AdminUserEcommerce.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("QlBanValiContext");
builder.Services.AddDbContext<QlbanVaLiContext>(options =>
{
    options.UseSqlServer(connectionString);
});
builder.Services.AddScoped<ILoaiSpRepository, LoaiSpRepository>();
builder.Services.AddSession();

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

app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Access}/{action=Login}/{id?}");

app.Run();
