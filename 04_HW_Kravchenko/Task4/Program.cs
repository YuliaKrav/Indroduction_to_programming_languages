// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

void printPairsMult(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Console.WriteLine("The multiplication of array[" + i + "] and array[" + (arr.Length - i - 1) + "] = " + (arr[i] * arr[arr.Length - i - 1]));
    }

    if (arr.Length % 2 != 0) Console.WriteLine("The middle element of array[" + (arr.Length / 2) + "] = " + arr[arr.Length / 2]);
}

int[] array = new int[9];

Console.Write("\nThe generated array [" + array.Length + "]: ");
fillArray(array, -10, 10);
printArray(array);
printPairsMult(array);
