// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

using System;

class Program
{
    static void Main(string[] args)
    {
        int array_size = 8;
        int[] array = new int[array_size];
        Random rnd = new Random();

        for (int i = 0; i < array_size; i++)
        {
            array[i] = rnd.Next(0, 2);
        }

        Console.WriteLine("The array[" + array_size + "] filled by 0 and 1:");
        for (int i = 0; i < array_size; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

