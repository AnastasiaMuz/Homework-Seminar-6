// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("Введите первое значение для первой прямой: ");
double b1 = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine ("Введите второе значение для первой прямой: ");
double k1 = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine ("Введите первое значение для второй прямой: ");
double b2 = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine ("Введите первое значение для второй прямой: ");
double k2 = Convert.ToDouble (Console.ReadLine ());

if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые не пересекаются");
}
if (k1 == k2 && b1 == b2 )
{
    Console.WriteLine ("Прямые совпадают");
}
double x = (b2 - b1)/(k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
if (y1 == y2)
{
    Console.WriteLine($"Координаты пересечения прямых равны ({x};{y1})");
}
// Console.WriteLine (x);
// Console.WriteLine (y1);
// Console.WriteLine (y2);