
using Group3_Hw8;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Cars_Controller
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
          
            // Add services to the container.

            //builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            //app.UseHttpsRedirection();

            //app.UseAuthorization();


            //app.MapControllers();
            app.Run(async (context) =>
            {
                CarsService CarsList = new CarsService();

                var request = context.Request;
                var response = context.Response;
                var path = request.Path;
                var parameters = request.QueryString.ToString();

                if (path == "/GetCarName" && parameters.Contains("?name="))
                {
                    //GetCarName?name=Ford

                    parameters = parameters.Replace("?name=", "");
                    var fords = CarsList.GetCarName(parameters);
                    await fords;
                    var fordQuery = fords.Result;

                    response.Headers.ContentLanguage = "en-US";
                    response.Headers.ContentType = "text/html";
                    var sb = new StringBuilder();
                    foreach (var h in fordQuery)
                    {
                        sb.Append($"<p>Make:{h.make}, Model:{h.model}, Speed:{h.speed}, Engine:{h.engine}, Year: {h.year}</p>");
                        sb.AppendLine();
                    }
                    await response.WriteAsync(sb.ToString());
                }
                if (path == "/GetCarEngine" && parameters.Contains("?engine="))
                {
                    //GetCarEngine?engine=dizel

                    parameters = parameters.Replace("?engine=", "");
                    var engine = CarsList.GetCarEngine(parameters);
                    await engine;
                    var engineQuery = engine.Result;

                    response.Headers.ContentLanguage = "en-US";
                    response.Headers.ContentType = "text/html";
                    var sb = new StringBuilder();
                    foreach (var h in engineQuery)
                    {
                        sb.Append($"<p>Make:{h.make}, Model:{h.model}, Speed:{h.speed}, Engine:{h.engine}, Year: {h.year}</p>");
                        sb.AppendLine();
                    }
                    await response.WriteAsync(sb.ToString());
                }
                if (path == "/GetCarAge" && parameters.Contains("?age="))
                {
                    //GetCarAge?age=9

                    parameters = parameters.Replace("?age=", "");
                    int parAge = Convert.ToInt32(parameters);
                    var age = CarsList.GetCarAge(parAge);
                    await age;
                    var ageQuery = age.Result;

                    response.Headers.ContentLanguage = "en-US";
                    response.Headers.ContentType = "text/html";
                    var sb = new StringBuilder();
                    foreach (var h in ageQuery)
                    {
                        sb.Append($"<p>Make:{h.make}, Model:{h.model}, Speed:{h.speed}, Engine:{h.engine}, Year: {h.year}</p>");
                        sb.AppendLine();
                    }
                    await response.WriteAsync(sb.ToString());
                }
            });
            app.Run();
        }
    }
}