using System;
using System.IO; 

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Exampl.txt"); 
                Console.WriteLine(content);    
                Console.ReadLine();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make sure the directory is correct");
            }
            catch (Exception ex)
            {
                Console.WriteLine("there was a problem!");
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                // code to finalize
                // setting objects to null 
                //closing databases connections
                Console.WriteLine("Closing application now...");
            }
            
            Console.ReadLine();
        }
    }
}
