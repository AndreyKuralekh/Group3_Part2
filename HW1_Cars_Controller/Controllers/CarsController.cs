using Microsoft.AspNetCore.Mvc;

namespace HW1_Cars_Controller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private CarsService CarsList = new CarsService();

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCarsList")]
        public IEnumerable<Vehicle> Get()
        {
            var carList = from Vehicle in CarsList.cars.ToList()
                          orderby Vehicle.make
                          select Vehicle;

            return carList.AsEnumerable();

        }
    }
}