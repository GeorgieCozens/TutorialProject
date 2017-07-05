﻿namespace com.georgieco.ConsoleApplication
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);

        int Factorial(int a);
        int AddThePreviousXOddNumbersToY(int x, int y);

    }
}