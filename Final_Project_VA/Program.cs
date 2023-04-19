using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Final_Project_VA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();



            Console.WriteLine("Please enter your state");
            var state = Console.ReadLine();
            string apiCall = $"https://sandbox-api.va.gov/services/va_facilities/v0/facilities?state={state}&appid={APIkey}";
            Console.WriteLine(FacilityAPI.State(apiCall));


























            var builder = WebApplication.CreateBuilder(args);

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
        }
    }
}