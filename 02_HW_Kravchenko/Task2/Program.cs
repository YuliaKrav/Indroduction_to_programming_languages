// Показать четные числа от 1 до N

Console.Write("Enter any integer number: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("\nEven numbers from 1 to " + N + " :");
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}