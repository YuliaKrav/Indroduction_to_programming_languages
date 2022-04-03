// Найти произведение двух матриц

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

int[,] MultiplyTwoArrays(int[,] arr1, int[,] arr2)
{
    int[,] multArr = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(1); j++)
            for (int k = 0; k < arr1.GetLength(1); k++)
                multArr[i, j] += arr1[i, k] * arr2[k, j];

    return multArr;
}

int n1 = 5, m1 = 3; //n1xm1 array1 size
int n2 = 3, m2 = 4; //n2xm2 array2 size

int minArrayElement = 0, maxArrayElement = 3;
// int[,] array1 = {{1, 2}, {3,4}};
// int[,] array2 = {{5, 6}, {7,8}};
// array1 * array2 = {{19, 22}, {43,50}};

// int[,] array1 = {{15, 27}, {18,10}};
// int[,] array2 = {{35}, {16}};
// array1 * array2 = {{957}, {750}};

int[,] array1 = new int[n1, m1];
int[,] array2 = new int[n2, m2];

FillArray(array1, minArrayElement, maxArrayElement);
FillArray(array2, minArrayElement, maxArrayElement);

Console.WriteLine("A given array1: ");
PrintArray(array1);

Console.WriteLine("A given array2: ");
PrintArray(array2);

if (array1.GetLength(1) == array2.GetLength(0))
{
    Console.WriteLine("An array = array1 * array2: ");
    int[,] result = MultiplyTwoArrays(array1, array2);
    PrintArray(result);
}
else Console.WriteLine($"It is not possible to multiply array1 by array2 because of their sizes.");