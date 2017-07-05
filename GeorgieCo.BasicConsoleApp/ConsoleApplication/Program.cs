using System;
using System.Collections.Generic;

namespace com.georgieco.ConsoleApplication
{
    public class Program
    {
        private static readonly List<string> ListOfApplications = new List<string>(){
            "1. Calculator",
            "2. To be implemented..."
            };

        private int ApplicationInUse = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Georgie's first console application!");
            Console.WriteLine("Please enter the number of the app you are interested in using.");
            foreach(var application in ListOfApplications)
            {
                Console.WriteLine(application);
            }
            var optionChosen = Console.Read();
            // Implement logic to instantiate calculator class
            // set ApplicationInUse to 1
        }
    }
}
