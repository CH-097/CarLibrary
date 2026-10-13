using CarLibrary;

namespace CarLibrary
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        // Add a property of type Engine
        private Engine engine;  //composition, one class containing another


        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }


        // default constructor
        public Car() {
            make = "default make";
            model = "default model";
            year = 2026;
            engine = new Engine();
        }

        //custom constructor
        public Car(string make, string model, int year, Engine engine)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.engine = engine;
        }


        //method that starts the engine and printe 'Driving started'
        public void Drive()
        {
            engine.Start();  //start engine (calls Engine.Start)
            Console.WriteLine("Driving started");
        }

        //method that stops the engine and prints 'Driving stopped'
        public void Stop()
        {
            engine.Stop();
            Console.WriteLine("Driving stopped");
        }

    }
}
