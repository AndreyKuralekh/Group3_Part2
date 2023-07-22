using HW2_Cars_Controller;

namespace Group3_Part2_HW2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddRazorPages();

            var app = builder.Build();
            app.UseMiddleware<MiddlewareGetCarName>();
            app.UseMiddleware<MiddlewareGetCarEngine>();
            app.UseMiddleware<MiddlewareGetCarAge>();

            // Configure the HTTP request pipeline.
            /*
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();
            */

            app.Run();
        }
    }
}