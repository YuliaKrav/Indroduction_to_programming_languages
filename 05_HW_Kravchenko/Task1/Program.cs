// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// Предполагаем, что коэффикиенты не равны одновременно 0
// int b1 = 3, k1 = 5;
// int b2 = 3, k2 = 5;

// int b1 = 3, k1 = 5;
// int b2 = 16, k2 = 5;

int b1 = 5, k1 = 5;
int b2 = 3, k2 = -5;
int x, y;

if ((k1 == k2) && (b1 == b2))
    Console.WriteLine($"\nThe two lines y = {k1} * x + {b1} and y = {k2} * x + {b2} are the same.\n");
else if (k1 == k2)
    Console.WriteLine($"\nThe two lines y = {k1} * x + {b1} and y = {k2} * x + {b2} are parallel.\n");
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"\nThe intersection point of two lines y = {k1} * x + {b1} and y = {k2} * x + {b2} is ({x}, {y})\n");
}

