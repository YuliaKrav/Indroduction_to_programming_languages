// Найти расстояние между точками в пространстве 2D

Console.WriteLine("Enter coordinates of two points: ");
Console.Write("Point1.X = ");
int point1X = int.Parse(Console.ReadLine());
Console.Write("Point1.Y = ");
int point1Y = int.Parse(Console.ReadLine());

Console.Write("Point2.X = ");
int point2X = int.Parse(Console.ReadLine());
Console.Write("Point1.Y = ");
int point2Y = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(point1X - point2X, 2) + Math.Pow(point1Y - point2Y, 2));

Console.Write("The distanse between (" + point1X + ", " + point1Y + ") and (" + point2X + ", " + point2Y + ") = " + Round(distance, 2));