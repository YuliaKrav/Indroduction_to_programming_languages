// Найти сумму цифр числа

int RecSumNumberDigits(int num)
{
    if (num == 0) return 0;
    else return (num % 10) + RecSumNumberDigits(num / 10);
}

Console.Write($"Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of number digits = {RecSumNumberDigits(number)}.");


// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         int l = Convert.ToInt32(Console.ReadLine());
//         int p = Convert.ToInt32(Console.ReadLine());
//         int q = Convert.ToInt32(Console.ReadLine());

//         float l1 = (float)(l * p) / (p + q);
//         Console.WriteLine(l1);
//     }
// }