using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace s
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original App before refactoring s

            // Console.WriteLine("The Name Game");

            // Console.Write("What's your first name? ");
            // string firstName = Console.ReadLine();

            // Console.Write("What's your last name? ");
            // string lastName = Console.ReadLine();

            // Console.Write("In what city were you born?");
            // string city = Console.ReadLine();

            // char[] firstNameArray = firstName.ToCharArray();
            // Array.Reverse(firstNameArray);

            // char[] lastNameArray = lastName.ToCharArray();
            // Array.Reverse(lastNameArray);

            // char[] cityArray = city.ToCharArray();
            // Array.Reverse(cityArray);

            // string result = "";

            // foreach (char item in firstNameArray)
            // {
            //     result += item;
            // }

            // result += " ";

            // foreach (char item in lastNameArray)
            // {
            //     result += item;
            // }

            // result += " ";

            // foreach (char item in cityArray)
            // {
            //     result += item;
            // }

            // Console.WriteLine("Results: " + result);

            //Console.ReadLine();

            
            // REFACTORED APP WITH METHODS

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            // call method. 
            //displays result of reversing the 3 string variables              
            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city)); 

            Console.ReadLine();
            
        }
        
        // method that reverses a string
        private static string ReverseString(string message)
        {
            // all chars in message into array
            char[] messageArray = message.ToCharArray();
            // reverse all chars in array 
            Array.Reverse(messageArray);
            // ['b', 'o', 'r'] -> 'bor'
            return String.Concat(messageArray); 
        }

        // method to display result of reversed strings
        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCity)
        {

            Console.WriteLine("Results: ")            
            //Format new String with "FN LN City"
            Console.WriteLine(String.Format("{0} {1} {2}", 
                    reversedFirstName, 
                    reversedLastName, 
                    reversedCity));
            // -> "Results: FN LN City"
        }
    }
} 