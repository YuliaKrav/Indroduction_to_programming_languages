// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Enter an integer numbers:");
long number = Int64.Parse(Console.ReadLine());

if (number > 99)
{
    long add_number = number;
    while (add_number >= 1000)
    {
        add_number /= 10;
    }
    Console.WriteLine("The third digit of the number " + number + " is " + add_number % 10);
}
else
{
    Console.WriteLine("The number is too short (less then three-digit number).");
}