// 12. Минимальный элемент, расположенный на побочной диагонали матрицы

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

int MinElArrayMinorDiagonal(int[,] arr)
{
    int maxIndex = arr.GetLength(0) - 1;
    int minElMinorDiagonal = arr[maxIndex, 0];

    for (int i = maxIndex; i >= 0; i--)
    {
        if (arr[i, maxIndex - i] < minElMinorDiagonal) minElMinorDiagonal = arr[i, maxIndex - i];
    }
    return minElMinorDiagonal;
}

int n = 5, m = 5; //nxm array size
int minArrayElement = -10, maxArrayElement = 10;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);
Console.WriteLine("A given matrix: ");
PrintArray(array);

if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"The minimum element of the minor diagonal of the matrix is {MinElArrayMinorDiagonal(array)}.");
else
    Console.WriteLine($"The matrix [{array.GetLength(0)}, {array.GetLength(1)}] is not a square matrix.");
