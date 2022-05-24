double GetDoubleValue(string text)
{
    Console.Write($"Введите значение {text}: ");
    double value = double.Parse(Console.ReadLine()?? "");
    return(value);
}


// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
/*
Решим систему уравнений:
|y = k1 * x + b1|   |y - y = (k1 - k2)*x - (b1-b2)|   |-(k1 - k2)*x = - b1-b2|   |x = (b1 - b2)/(k1 - k2)
|               | = |                             | = |                      | = |
|y = k2 * x + b2|   |y = k2 * x + b2              |   |y = k2 * x + b2       |   |y = k2 * x + b2
*/
Console.Clear();
Console.WriteLine("Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2");
double k1 = GetDoubleValue("k1");
double b1 = GetDoubleValue("b1");
double k2 = GetDoubleValue("k2");
double b2 = GetDoubleValue("b2");

double xPoint = (b1 - b2)/(k1 - k2);
double yPoint = k2 * xPoint + b2;

Console.WriteLine($"Координаты точки пересечения для k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} равны х = {xPoint} и y = {yPoint}.");