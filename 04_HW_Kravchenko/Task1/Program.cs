// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел.

void fillArray(int[] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(startEl, endEl + 1);
    }
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int countOddNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 1) count++;
    }
    return count;
}

int countEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = new int[20];

Console.Write("\nThe generated array [" + array.Length + "]: ");
fillArray(array, 100, 999);
printArray(array);

Console.WriteLine("There are " + countOddNumbers(array) + " odd numbers and "
                    + countEvenNumbers(array) + " even numbers.\n");



