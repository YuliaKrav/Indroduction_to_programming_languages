// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Enter a three-digit integer numbers:");
int number = Int32.Parse(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    Console.WriteLine(number % 10 + " is the last digit of " + number);
}
else
{
    Console.WriteLine("The input number is not a three-digit integer numbers.");
}