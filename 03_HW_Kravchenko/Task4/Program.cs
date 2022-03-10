// Написать программу вычисления произведения чисел от 1 до N
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter any integer number: ");
        int N = int.Parse(Console.ReadLine());
        int mult = 1;

        for (int i = 1; i <= N; i++)
        {
            mult *= i;
        }

        Console.WriteLine("The multiplication of numbers from 1 to " + N + " = " + mult);
    }
}