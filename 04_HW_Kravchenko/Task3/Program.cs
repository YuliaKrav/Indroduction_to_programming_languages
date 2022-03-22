// Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

int sumNumbersOddPosition(int[] arr)
{
    int sum = 0;
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     if (i % 2 != 0) sum += arr[i];
    // }
    // return sum;

    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] array = new int[20];

Console.Write("\nThe generated array [" + array.Length + "]: ");
fillArray(array, -10, 10);
printArray(array);

Console.WriteLine("The sum of elements on odd array indexes = " + sumNumbersOddPosition(array) + "\n");


