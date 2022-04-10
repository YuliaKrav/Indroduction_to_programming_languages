// Написать программу вычисления функции Аккермана

Console.Write($"Enter the first parameter of the Ackermann function (m): ");
long parameterM = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter the second parameter of the Ackermann function (n): ");
long parameterN = Convert.ToInt32(Console.ReadLine());

long AckermannFunction(long m, long n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.WriteLine($"The Ackermann functionts({parameterM}, {parameterN}) = {AckermannFunction(parameterM, parameterN)}.");

