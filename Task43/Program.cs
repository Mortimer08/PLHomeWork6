// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionCoordinates(double b1, double k1, double b2, double k2)
{
    double[] coordinates = new double[2];
    coordinates[0] = Math.Round((b2 - b1) / (k1 - k2), 1);
    coordinates[1] = Math.Round(k1 * coordinates[0] + b1, 1);
    return coordinates;
}

Console.Write("Введите b1: ");
double ratioB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double ratioK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double ratioB2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double ratioK2 = Convert.ToDouble(Console.ReadLine());

double[] intersectionCoordinates = IntersectionCoordinates(ratioB1, ratioK1, ratioB2, ratioK2);
Console.WriteLine($"Координаты точки пересечения: ({intersectionCoordinates[0]}, {intersectionCoordinates[1]})");