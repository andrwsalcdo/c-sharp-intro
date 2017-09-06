using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now; 

            // ex: 9/6/2017 11:29:35 
            // Console.WriteLine(myValue.ToString());

            // ex: 9/6/2017
            // Console.WriteLine(myValue.ToShortDateString());

            // ex: 3:35 PM 
            // Console.WriteLine(myValue.ToShortTimeString());

            // ex: Tuesday, March 15, 2016
            // Console.WriteLine(myValue.ToLongDateString());

            // ex: 2:20:45 
            // Console.WriteLine(myValue.ToLongTimeString());

            // today + 3 -> ex: Saturday, September 9, 2017
            // Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            // subtract days 
            // Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            // DateTime myBirthday = new DateTime(1969, 12, 7); 
            // Console.WriteLine(myBirthday.ToShortDateString());

            //how many hours or days since birthday
            DateTime myBirthday = DateTime.Parse("5/22/1967");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday); 

            Console.WriteLine(myAge.TotalDays); // 18,370 days. 

            Console.ReadLine();
        }
    }
}
