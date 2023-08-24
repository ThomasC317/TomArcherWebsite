using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TomArcherMusic.Data;
using TomArcherMusic.Services.Implementation;
using TomArcherMusic.Services.Interfaces;

namespace TomArcherMusic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            //builder.Services.AddHttpClient("ApiClient", (provider, client) =>
            //{
            //    client.BaseAddress = new Uri("https://localhost:7073/TomArcherMusic/");
            //});
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7073/TomArcherMusic/") });
            builder.Services.AddScoped<IMusicCardService,MusicCardService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}