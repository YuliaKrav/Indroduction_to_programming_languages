// A. Чётные на чётных
// Вводится последовательность чисел. Посчитать в ней количество чётных чисел, стоящих на чётных 
// местах.
// Входные данные
// Вводится сначала число N, а затем N чисел - члены последовательности.
// Выходные данные
// Выведите количество чётных чисел, стоящих на чётных местах в последовательности.
// Примеры
// входные данные
// Скопировать
// 7
// 1 1 1 1 1 1 1
// выходные данные
// Скопировать
// 0
// входные данные
// Скопировать
// 6
// 1 2 3 4 5 6
// выходные данные
// Скопировать
// 3

int N = Convert.ToInt32(Console.ReadLine()); //N чисел - члены последовательности
int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

int count = 0;
for (int i = 0; i < N; i++)
{
    if (i % 2 != 0 && numbers[i] % 2 == 0)
        count++;
}

Console.WriteLine(count);

