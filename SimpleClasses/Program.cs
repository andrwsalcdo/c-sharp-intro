using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a new instance of the class
            Car myCar = new Car(); 

            // getting the properties
            myCar.Make = "Oldsmobile"; 
            myCar.Model = "Cutlas Supreme"; 
            myCar.Year = 1986; 
            myCar.Color = "Silver"; 

            // setting the properties
            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);

            // decimal value = DetermineMarketValue(myCar); 
            // turn into currency 
            // Console.WriteLine("{0:C}", value);

            // -> $2,000.00 
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M; 

            //someday look up car online webservice to get more accurate value
            return carValue; 
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }       
        public int Year { get; set; }   
        public string Color { get; set; }

        public decimal DetermineMarketValue() 
        {
            decimal carValue; 

            if (Year > 1990) 
                carValue = 10000; 
            else 
                carValue = 2000; 
            
            return carValue; 
        }
    }
}
