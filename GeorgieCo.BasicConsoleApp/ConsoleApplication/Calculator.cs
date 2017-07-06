using System;

namespace com.georgieco.ConsoleApplication
{
    public class Calculator : ICalculator
    {

        public Calculator()
        {
            Console.WriteLine("You chose calculator - good job!");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Factorial(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("number cannot be negative");
                return 0;
            }
            if (a==0)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }

        public int Multiply(int a, int b)
        {
            return a*b;
        }

        public int Subtract(int a, int b)
        {
            return a-b;
        }

        private void Exit()
        {
            // Implement logic to return to the main menu i.e. the Main method of Program.cs
            // set application in use to 0 for the program
        }
    }
}
