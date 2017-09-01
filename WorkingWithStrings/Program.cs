using System;  
using System.Text;


namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //  back slash\ allows ironic double quotes"" in a string
            string myString = "My \"so-called\" life"; 
            //   \n character creates a new line.
            string myString2 = "What if I \nneed a new line?"; 
            // @ allows \ to be used in the string as normal. 
            string myString3 = @"Go to your c:\ drive"; 

            // {number} can be used in different order, multiple times, etc
            // {1} = {0} -> Second = First 
            // {0} = {0} -> First = First etc
            string myString4 = string.Format("{1} = {0}", "First", "Second"); 

            // {num:C} display currency native to your pc's language & culture
            string myString5 = string.Format("{0:C}", 123.45); // $123.45

            // {num:N} formats number such as -> 1,234,556,789.00
            string myString6 = string.Format("{0:N}", 1234556789); 

            // {num:P} display number as percentage -> 12.3%
            string myString7 = string.Format("Percentage: {0:P}", .123); 
            
            // -> (123) 456-7890
            string myString8 = string.Format("Phone Number: {0:(###) ###-####}", 1234567890); 

            string myString9 = " That summer we took threes across the board "; 

            //grabs string from (num, num2) in range
            // .Substring(6) -> summer we took threes across the board
            // .Substring(6,14) -> summer we took
            myString9 = myString9.Substring(6, 14); 

            //everything UPPERCASE
            myString9 = myString9.ToUpper(); 
            
            // replaces empty spaces with -- 
            // ex: "i am cat" -> "i--am--cat"
            myString9 = myString9.Replace(" ", "--");  

            string myString13 = " That summer we took threes across the board "; 
            
            // --> " That  threes across the board "
            myString13 = myString13.Remove(6,14);             
            // Trims off whitespaces at the beginned & end of string. 
            myString13 = myString13.Trim();                               
            
            //set empty string before for code block
            string myString10 = ""; 
            for (int i = 0; i < 100; i++)
            {
                myString10 += "--" + i.ToString(); // -> --0--1--2--etc
            }
            //for method isn't good for lots of string manipulation or concatenation.
            // memory intensive 


            //StringBuilder is better for lots of string manipulation
            //instantiate new stringBuilder class
            StringBuilder myString11 = new StringBuilder(); 

            for (int i = 0; i < 100; i++)
            {
                myString11.Append("--"); 
                myString11.Append(i); //append is more efficient & faster
            }


            Console.WriteLine(myString11);            
            Console.ReadLine();
            
        }
    }
}
