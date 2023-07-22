using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Cars_Controller
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareGetCars
    {
        private readonly RequestDelegate requestDelegate;

        public MiddlewareGetCars(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            
            CarsService CarsList = new CarsService();

            var request = context.Request;
            var response = context.Response;

            response.ContentType = "text/html";
            //await response.SendFileAsync("html/HelloHtmlpage.html");
           

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
            else 
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
            } else 
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
            else 
                await requestDelegate.Invoke(context);
        }
    }


}
