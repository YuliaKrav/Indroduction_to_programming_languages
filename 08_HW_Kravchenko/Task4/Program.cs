// 4. Минимальный элемент матрицы

void FillArray(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(startEl, endEl + 1);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            //Console.Write(arr[i, j] + " ");
            Console.Write(String.Format("{0,4}", arr[i, j]));
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinArrayElements(int[,] arr)
{
    int minEl = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minEl) minEl = arr[i, j];
        }
    }
    return minEl;
}

int n = 4, m = 5; //nxm array size
int minArrayElement = -100, maxArrayElement = 100;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);
Console.WriteLine("A given matrix: ");
PrintArray(array);

Console.WriteLine($"The minimum element of the matrix is {MinArrayElements(array)}");