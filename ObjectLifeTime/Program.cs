using System;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(); 

            Car.myMethod(); 

            // myCar.Make = "Oldsmobile"; 
            // myCar.Model = "Cutlas Supreme"; 
            // myCar.Year = 1986; 
            // myCar.Color = "Silver"; 

            // Car myOtherCar; 
            // myOtherCar = myCar; 

            // Console.WriteLine("{0} {1} {2} {3}", 
            //     myOtherCar.Make, 
            //     myOtherCar.Model,
            //     myOtherCar.Year, 
            //     myOtherCar.Color);

            //this removes the reference 
            // myOtherCar = null; 

            Console.ReadLine();    
        }
    }
    
     class Car
    {
        public string Make { get; set; }   
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // constructor: used to make object into a valid state
        // so that it's immediately usable at the point of whenever it's instantiated. 
        // Public Car()
        {   
            // you could load from a config file, a database, etc. 
            // Make = "Nissan"; 
        // }    

        // overloaded constructor 
        public Car(string make, string model, int year, string color)
        {
            Make = make; 
            Model = model 
            Year = year; 
            Color = color; 
        }

        public static void MyMethod() 
        {
            Console.WriteLine("Called the static myMethod");
        }
    }
}
