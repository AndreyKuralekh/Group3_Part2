using Microsoft.AspNetCore.Mvc;

namespace HW1_Cars_Controller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private Cars CarsList = new Cars();

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCarsList")]
        public IEnumerable<Car> Get()
        {
            var carList = from car in CarsList.cars.ToList()
                          orderby car.make
                          select car;

            return carList.AsEnumerable();

        }
    }
}