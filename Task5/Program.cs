// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Enter two coordinates of the point - X and Y, X ≠ 0 и Y ≠ 0: ");
Console.Write("Enter the first coordinate X = ");
int pointX = int.Parse(Console.ReadLine());
Console.Write("Enter the second coordinate Y = ");
int pointY = int.Parse(Console.ReadLine());

if (pointX > 0 && pointY > 0) Console.Write("The point with coordinates (" + pointX + ", " + pointY + ") is in the 1st Quadrant.");
else if (pointX < 0 && pointY > 0) Console.Write("The point with coordinates (" + pointX + ", " + pointY + ") is in the 2nd Quadrant.");
else if (pointX < 0 && pointY < 0) Console.Write("The point with coordinates (" + pointX + ", " + pointY + ") is in the 3rd Quadrant.");
else if (pointX > 0 && pointY < 0) Console.Write("The point with coordinates (" + pointX + ", " + pointY + ") is in the 4th Quadrant.");
else Console.Write("The point with coordinates (" + pointX + ", " + pointY + ") is on the coordinate axes.");