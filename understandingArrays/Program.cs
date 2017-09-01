using System;

namespace understandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  wrong approach. use Arrays to find variable with 16
            int number1 = 4; 
            int number2 = 8; 
            int number3 = 15; 
            int number4 = 16; 
            int number5 = 23; 

            if (number1 == 16)
            {
            }
            else if (number2 == 16)
            {
            }
            else if (number3 == 16)
            {
            }
             */
            
            // Part 1
             
            // How to create an Array. more on *=,new* later. 
            int[] numbers = new int[5]; 

            numbers[0] = 4; 
            numbers[1] = 8; 
            numbers[2] = 15; 
            numbers[3] = 16; 
            numbers[4] = 23; 
            
            Console.WriteLine(numbers[1]); // 8 
            Console.WriteLine(numbers.Length); // 5. elements in arr
            Console.ReadLine();

            //new array 
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 }; 
            
            
            // Part 2

            // string array 
            string[] names = new string[] { "ed", "alex", "michael", "david" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            
            // Can use foreach instead of for
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            

            // Part 3

            string zig = "You can get what you want out of life " +
                    " if you help enough other people get what they want."; 
            
            // create a new array of each character in string zig
            // data type is Char...unicode character. letter, spaces, etc
            char[] charArray = zig.ToCharArray(); 
            // Reverse the characters in the array
            Array.Reverse(charArray); 
            
            //Write all chars in the array
            foreach (char zigChar in charArray)
            {
                Console.WriteLine(zigChar); // zig is written backwards. 
            }
            Console.ReadLine();
            

            
        }
    }
}
