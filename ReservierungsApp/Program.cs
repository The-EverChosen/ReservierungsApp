using Microsoft.EntityFrameworkCore;
using ReservierungsApp.Data;

namespace ReservierungsApp
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplikationDbContext>(option => option.UseInMemoryDatabase("ReservationsDb")); //BeiUseinMemoryDatabes kann ausgetauscht werden gegen richtige Datenbank
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
                pattern: "{controller=Reservations}/{action=Index}/{id?}");
                 

            app.Run();
        }
    }
} 