using ServiceApp.Services;
using ServiceApp.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Data.Entities;
using Data;

namespace ServiceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddSingleton<ITicketService, MemoryTicketService>();



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

            DatabaseFacade databaseFacade = new DatabaseFacade(new AppDbContext());
            databaseFacade.EnsureCreated();

            app.Run();
        }
    }
}