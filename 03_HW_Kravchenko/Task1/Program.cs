// Найти кубы чисел от 1 до N
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter any integer number: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("N^3, N = 1 to " + N + ":");
        for (int i = 1; i <= N; i++)
        {
            Console.Write(i * i * i + " ");
            //Console.Write(Math.Pow(i, 3) + " ");
        }
    }
}
