using Group3_Hw8;
using System.Xml.Linq;

namespace HW1_Cars_Controller
{
    public class CarsService : IManagementCars
    {
        public ManagedCollection<Vehicle> cars = new ManagedCollection<Vehicle>();
        public CarsService() 
        {
            cars.Add(new Car("Ford", "Mondeo", 2014, 180, "gaz"));
            cars.Add(new Car("Mersedes", "A-160", 2001, 140, "dizel"));
            cars.Add(new Car("Ford", "Scorpio", 1994, 90, "gaz"));
            cars.Add(new Car("BMW", "A6", 2004, 230, "gaz"));
            cars.Add(new Car("Cherry", "Amulet", 2014, 110, "gaz"));

            //var fords = GetCarName("Ford");
            //var dizel = GetCarEngine("dizel");
            //var car2014 = GetCarAge(9);
        }
        public async Task<IOrderedEnumerable<Vehicle>> GetCarName(string name)
        {
            var carList = from Vehicle in cars
                          where Vehicle.make.Equals(name)
                          orderby Vehicle.make
                          select Vehicle;

            await Task.Delay(0);

            return carList;
        }
        public async Task<IOrderedEnumerable<Vehicle>> GetCarEngine(string engine)
        {
            var carList = from Vehicle in cars
                          where Vehicle.engine.Equals(engine)
                          orderby Vehicle.make
                          select Vehicle;
            await Task.Delay(0);
            return carList;
        }
        public async Task<IOrderedEnumerable<Vehicle>> GetCarAge(int age)
        {
            int year = DateTime.Now.Year - age;
            var carList = from Vehicle in cars
                          where Vehicle.year.Equals(year)
                          orderby Vehicle.make
                          select Vehicle;
            await Task.Delay(0);
            return carList;
        }
    }
}
