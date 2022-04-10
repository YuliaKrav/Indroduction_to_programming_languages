// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int RecSequence(int a, int b, int n)
{
    if (n == 1) return a;
    else if (n == 2) return b;
    else return RecSequence(a, b, n - 1) + (RecSequence(a, b, n - 2));
}

Console.Write($"Enter the number of elements of the sequence: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Enter the first element of the sequence: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"Enter the second element of the sequence: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"The first {number} elements of the sequence: \n{firstNumber} {secondNumber} ");

for (int i = 3; i <= number; i++)
    Console.Write($"{RecSequence(firstNumber, secondNumber, i)} ");
