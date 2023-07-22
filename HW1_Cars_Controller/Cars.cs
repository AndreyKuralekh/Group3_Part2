using Group3_Hw8;

namespace HW1_Cars_Controller
{
    public class Cars
    {
        public ManagedCollection<Car> cars = new ManagedCollection<Car>();
        public Cars() 
        {
            cars.Add(new Car("Ford", "Mondeo", 2014, 180));
            cars.Add(new Car("Mersedes", "A-160", 2001, 140));
            cars.Add(new Car("Ford", "Scorpio", 1994, 90));
            cars.Add(new Car("BMW", "A6", 2004, 230));
            cars.Add(new Car("Cherry", "Amulet", 2014, 110));
        }
    }
}
