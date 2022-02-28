// Выяснить является ли число чётным

Console.WriteLine("Enter an integer numbers:");
int number = Int32.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("A number " + number + " is even.");
}
else
{
    Console.WriteLine("A number " + number + " is odd.");
}