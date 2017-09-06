using System;
using System.Net; 

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WebClient client = new WebClient(); 
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            
            Console.ReadLine();        
        }
    }
}
