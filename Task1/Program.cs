// Показать числа от -N до N

Console.Write("Enter any integer number: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Numbers from " + -N + " to " + N + ":");
for (int i = -N; i <= N; i++)
{
    Console.Write(i + " ");
}
