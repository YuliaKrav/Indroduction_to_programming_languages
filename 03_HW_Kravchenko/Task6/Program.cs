// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

class Program
{
    static void Main(string[] args)
    {
        int array_size = 12;
        int[] array = new int[array_size];
        Random rnd = new Random();
        int sum_negative = 0;
        int sum_positive = 0;

        for (int i = 0; i < array_size; i++)
        {
            array[i] = rnd.Next(0, 10);
            if (array[i] > 0) sum_positive += array[i];
            else sum_negative += array[i];
        }

        Console.WriteLine("The array[" + array_size + "] filled by [0, 9]:");
        for (int i = 0; i < array_size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\nThe sum of positive values = " + sum_positive);
        Console.WriteLine("The sum of negative values = " + sum_negative);
    }
}