using System.ComponentModel.DataAnnotations;
using System;
using CarLibrary;

namespace CarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new instance of Engine called engine with cylinders = 4, horsepower = 210
            Engine engine = new Engine(4, 210);


            //create new instance of Car with the values make=”Ford”, model=”Fiesta”, year=2016, engine = engine
            Car car = new Car("Ford", "Fiesta", 2016, engine);
            car.Drive();  // starts the engine + prints "driving started"
            car.Stop();  // stops the engine + prints "driving stopped"


            /*   output:
             * Engine starting
               Driving started
               Engine stopping
               Driving stopped
            */
        }
    }
}