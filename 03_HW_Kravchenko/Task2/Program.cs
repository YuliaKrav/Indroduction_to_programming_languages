// Найти сумму чисел от 1 до А
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter any integer number: ");
        int A = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= A; i++)
        {
            sum += i;
        }

        Console.WriteLine("The sum of numbers from 1 to " + A + " = " + sum);
    }
}