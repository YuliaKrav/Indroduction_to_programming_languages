// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Enter an integer numbers from 10 to 99:");
int number = Int32.Parse(Console.ReadLine());
int max_digit;

if (number >= 10 && number <= 99)
{
    if ((number / 10) % 10 > number % 10)
    {
        max_digit = (number / 10) % 10;
    }
    else
    {
        max_digit = number % 10;
    }
    Console.WriteLine(max_digit + " is the maximum digit of " + number);
}
else
{
    Console.WriteLine("The input number does not belong the range [10, 99].");
}