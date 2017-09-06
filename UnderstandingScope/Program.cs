using System;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = ""; 

        static void Main(string[] args)
        {

            string j = ""; 

            for (int i =  0; i < 10; i++)
            {
                j = i.ToString(); 
                k = i.ToString(); 
                Console.WriteLine(i);
            }
            //invalid. outside of for loop scope. 
            Console.WriteLine(i);
            // j is accesible inside and outside for loop. 
            Console.WriteLine(j);
            // k is accesible as well. 
            Console.WriteLine(k);

            // k is accessible because it is defined at the "class-level"
            HelperMethod(); 

            // instatiate car class 
            Car myCar = new Car();
            // calls the public method DoSomething(). 
            // can't call the Car class's helperMethod directly, because it's private 
            myCar.DoSomething() // -> hello world!

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("you can see k value" + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!"; 
        }
    }
}
