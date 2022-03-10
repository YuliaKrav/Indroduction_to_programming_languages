// Подсчитать сумму цифр в числе

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter any integer number: ");
        int number = int.Parse(Console.ReadLine());
        int number_temp = number;
        int sum_digits = 0;

        while (number_temp > 0)
        {
            sum_digits += number_temp % 10;
            number_temp /= 10;
        }

        Console.WriteLine("The sum of number digits " + number + " = " + sum_digits);
    }
}

