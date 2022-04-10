// Написать программу возведения числа А в целую стень B

int RecPowAB(int a, int b)
{
    if (b == 0) return 1;
    else return a * RecPowAB(a, b - 1);
}

Console.Write($"Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter a power of the number: ");
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number}^{power} = {RecPowAB(number, power)}.");
