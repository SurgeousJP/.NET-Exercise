using ECommerce.ProductModels;
using Microsoft.EntityFrameworkCore;

namespace ECommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddRouting(options => options.LowercaseUrls = true);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            // Add Db context for catalog
            builder.Services.AddDbContext<QlbanVaLiContext>(options =>
            {
                options.UseSqlServer(
                    builder.Configuration["ConnectionStrings:Vali"
                    ]);
                options.EnableSensitiveDataLogging();
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}
