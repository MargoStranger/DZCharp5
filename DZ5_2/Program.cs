//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//k1- коэффициент  b1 -  смещение
//(b2 - b1) / (k1 - k2) (для х), y наточке пересечения одинаковый

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите коэффициент 1 числа: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите смещение 1 числа: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите коэффициент 2 числа: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите смещение 2 числа: ");
double b2 = double.Parse(Console.ReadLine()!);

Console.Write($"Точка пересечения {String.Join("; ", GetPoint(k1,k2,b1,b2))}");

//метод поиска точки пересечения
double[] GetPoint(double k1, double k2, double b1, double b2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;
    return array;
}