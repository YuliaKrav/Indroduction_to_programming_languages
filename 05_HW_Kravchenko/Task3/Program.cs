// Написать программу масштабирования фигуры

//         Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//         например: "(0,0) (2,0) (2,2) (0,2)"
//         коэффициент масштабирования k задавался отдельно - 2 или 4 или 0,5
//         В результате показать координаты, которые получатся.
//         при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)");

void PrintCoordinates(double[] shape)
{
    for (int i = 0; i < shape.Length; i += 2)
    {
        Console.Write($"({shape[i]}, {shape[i + 1]}) ");
    }
    Console.WriteLine();
}

Console.Write("\nEnter shape's coordinates in the string format '(0,0) (4,0) (4,4) (0,4)' : ");
String stringCoordinatesShape = Console.ReadLine() ?? "(0,0) (2,0) (2,2) (0,2)"; //"(0,0) (2,0) (2,2) (0,2) (3,3)";

Console.Write("Enter a scaling factor 2, 4 or 0,5: ");
double k = double.Parse(Console.ReadLine() ?? "2");

char[] separatorsSplit = new char[] { ' ', '(', ')', ',' };
//x -even positions, y - odd positions in array coordinates
double[] coordinatesShape = stringCoordinatesShape.Split(separatorsSplit, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
Console.WriteLine("\nOld small shape coordinates are : ");
PrintCoordinates(coordinatesShape);
//int numberOfPoints = coordinatesShape.Length / 2;

Console.WriteLine("New large shape coordinates are : ");
double[] newCoordinatesLargeShape = new double[coordinatesShape.Length];
for (int i = 0; i < coordinatesShape.Length; i += 2)
{
    newCoordinatesLargeShape[i] = coordinatesShape[i] * k;
    newCoordinatesLargeShape[i + 1] = coordinatesShape[i + 1] * k;
}

PrintCoordinates(newCoordinatesLargeShape);
Console.WriteLine();