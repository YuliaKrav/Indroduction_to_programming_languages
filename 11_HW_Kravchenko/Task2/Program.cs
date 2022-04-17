// B. Наибольшее произведение

// Дано N целых чисел. Требуется выбрать из них два таких числа, произведение которых максимально.
// Входные данные
// Вводится сначала число N - количество чисел в последовательности (2 <  = N <  = 100). Далее 
// записана сама последовательность: N целых чисел, по модулю не превышающих 1000.
// Выходные данные
// Выведите два искомых числа в любом порядке. Если существует несколько различных пар чисел, 
// дающих максимальное произведение, то выведите любую из них.
// Примеры
// входные данные
// Скопировать
// 9
// 3 5 1 7 9 0 9 -3 10
// выходные данные
// Скопировать
// 9 10
// входные данные
// Скопировать
// 3
// -5 -300 -12
// выходные данные
// Скопировать
// -300 -12

int N = Convert.ToInt32(Console.ReadLine()); //N - количество чисел в последовательности (2 <  = N <  = 100).
// N целых чисел, по модулю не превышающих 1000.
int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

int max1, max2, min1, min2;

if (numbers[0] > numbers[1])
{
    max1 = numbers[0];
    max2 = numbers[1];
    min2 = numbers[0];
    min1 = numbers[1];
}
else
{
    max1 = numbers[1];
    max2 = numbers[0];
    min2 = numbers[1];
    min1 = numbers[0];
}

for (int i = 2; i < N; i++)
{
    if (max1 < numbers[i])
    {
        max2 = max1;
        max1 = numbers[i];
    }
    else if (max2 < numbers[i])
        max2 = numbers[i];


    if (min1 > numbers[i])
    {
        min2 = min1;
        min1 = numbers[i];
    }
    else if (min2 > numbers[i])
        min2 = numbers[i];
}

if (min1 * min2 > max1 * max2)
    Console.WriteLine(min1 + " " + min2);
else
    Console.WriteLine(max1 + " " + max2);


