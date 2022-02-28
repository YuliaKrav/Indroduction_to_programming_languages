// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Enter two integer numbers - dividend and divisor:");
Console.Write("Enter the  dividend: ");
int dividend = Int32.Parse(Console.ReadLine());
Console.Write("Enter the divisor: ");
int divisor = Int32.Parse(Console.ReadLine());

if (dividend % divisor == 0)
{
    Console.WriteLine("The number " + dividend + " is evenly divided by " + divisor);
}
else
{
    Console.WriteLine("The number " + dividend + " is divided by " + divisor + " with the remainder = " + dividend % divisor);
}