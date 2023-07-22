namespace HW2_Cars_Controller
{
    public class Car : Vehicle
    {
        public Car() :this("Noname")
        { 
        
        }
        public Car(string make) :this(make, "NoName")
        { 
            this.make = make;
        }
        public Car(string make, string model) : this(make, "NoName", 1900)
        { 
            this.make = make;
            this.model = model;
        }
        public Car(string make, string model, int year) : this(make, "NoName", year, 0)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public Car(string make, string model, int year, int speed) : this(make, "NoName", year, 0, "gaz")
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.speed = speed;
        }
        public Car(string make, string model, int year, int speed, string engine)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.speed = speed;
            this.engine = engine;
        }
    }
}
