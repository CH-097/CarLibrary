using CarLibrary;

namespace CarLibrary
{
    public class Engine
    {
        //fields
        private int cylinders;
        private double horsepower;

        //properties
        public int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }
        public double Horsepower
        {
            get { return horsepower; }
            set { horsepower = value; }
        }

        //default constructor
        public Engine()
        {
            cylinders = 0;
            horsepower = 150.0;
        }

        //custom constructor
        public Engine(int cylinders, double horsepower)
        {
            this.cylinders = cylinders;
            this.horsepower = horsepower;
        }


        // method prints out "Engine starting"
        public void Start()
        {
            Console.WriteLine("Engine starting");
        }
        // method prints out "Engine stopping"
        public void Stop()
        {
            Console.WriteLine("Engine stopping");

        }

    }
}
