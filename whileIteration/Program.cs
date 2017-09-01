using System;

namespace whileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true; 
            //always display the main menu until false
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        // method that returns a boolean value: t | f
        private static bool MainMenu()
        {
            //clears unnecessary data being shown on screen
            Console.Clear(); 
            
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers(); 
                return true; 
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;  
            }
            else if (result == "3")
            {
                return false; //exits out of menu. app done. 
            }
            else
            {
                return true; 
            }
        }

        private static void PrintNumbers()
        {
            //clears unnecessary data being shown on screen
            Console.Clear(); 

            Console.WriteLine("Print numbers");
            Console.WriteLine("Type a number: ");
            //user entered number
            int result = int.Parse(Console.ReadLine()); 
            int counter = 1; 

            // display "counter-" -> 1-2-3 etc
            while (counter < result) 
            {
                Console.WriteLine(counter);
                Console.WriteLine("-");
                counter++; 
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
             //clears unnecessary data being shown on screen
            Console.Clear(); 

            Console.WriteLine("Guessing game!");

            //instatiate new class of Random
            Random myRandom = new Random(); 
            // a random number between 1 < x < 11
            int randomNumber = myRandom.Next(1, 11); 
            
            // user starts with 0 guesses. 
            int guesses = 0; 
            bool incorrect = true; 

            // execute this method while incorrect == true. 
            // executes this code block at least 1 time
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                //increment user's guesses
                guesses++;

                if (result == randomNumber.ToString())
                    incorrect = false; // break this code block. 
                else 
                    Console.WriteLine("Wrong!");

            } while (incorrect);
            // incorrect == false...
            Console.WriteLine("Correct! It took you {0} guesses.", guesses);

            Console.ReadLine();
        }
    }
}
