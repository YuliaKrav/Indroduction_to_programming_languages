// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

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

int countNuminRangeMinMax(int[] arr, int min_num, int max_num)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min_num && arr[i] <= max_num) count++;
    }
    return count;
}

int array_length = 123;
int min_number = 10;
int max_number = 99;
int[] array = new int[array_length];

Console.Write("\nThe generated array [" + array.Length + "]: ");
fillArray(array, 0, 100);
printArray(array);

Console.WriteLine("There are " + countNuminRangeMinMax(array, min_number, max_number) + " elements in range [" + min_number + ", " + max_number + "].\n");