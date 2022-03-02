// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Enter two integer numbers: ");
Console.Write("Enter the first numbers: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second numbers: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2 || number2 == number1 * number1)
{
    Console.Write("One of the numbers " + number1 + ", " + number2 + " is the square of another number.");
}
else
{
    Console.Write("One of the numbers " + number1 + ", " + number2 + " isn't the square of another number.");
}