// Найти максимальное из трех чисел

Console.WriteLine("Enter three integer numbers:");
Console.Write("Enter the first integer numbers: ");
int number1 = Int32.Parse(Console.ReadLine());
Console.Write("Enter the second integer numbers: ");
int number2 = Int32.Parse(Console.ReadLine());
Console.Write("Enter the third integer numbers: ");
int number3 = Int32.Parse(Console.ReadLine());

int max = number1;
if (max < number2) max = number2;
if (max < number3) max = number3;

Console.WriteLine(max + " is the maximum number from " + number1 + " " + number2 + " " + number3);

