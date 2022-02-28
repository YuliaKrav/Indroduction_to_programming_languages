// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Enter a three-digit integer numbers:");
int number = Int32.Parse(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    int new_number = number / 100 * 10 + number % 10;
    Console.WriteLine(new_number + " is the number " + number + " withot the second digit.");
}
else
{
    Console.WriteLine("The input number is not a three-digit integer numbers.");
}

