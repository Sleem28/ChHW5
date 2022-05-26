/*
Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/

// Сделаем масштабирование фигуры с четырьмя точками, как в примере. 

//-------------------------------------Заполняет элемент массива координатами-----------------------------------------+
void FillArrayElements(double[,] array, double valueX,double valueY)
{
    int    rowsLength  = array.GetLength(0);
    Random rnd         = new Random();
    int    sign        = 0;
    for (int i = 0; i < rowsLength; i++)
    {
        sign = rnd.Next(0,2);
        if(sign == 0) valueX = -valueX;
        array[i,0] = Math.Round(rnd.NextDouble() * valueX,2);
        sign = rnd.Next(0,2);
        if(sign == 0) valueY = -valueY;
        array[i,1] = Math.Round(rnd.NextDouble() * valueY,2);
    }
    
}
//-----------------------------------------PrintArray----------------------------------------------------------------+
void PrintArray(double[,] array)
{
    int length = array.GetLength(0);
    for (int i = 0; i < length; i++)
    {
       Console.Write($"({array[i,0]};{array[i,1]}) " );
    }
}
//----------------------------------------Масштабируем---------------------------------------------------------------+
void Scaling(double[,] array,double coef)
{
    int length = array.GetLength(0);
    for (int i = 0; i < length; i++)
    {
       array[i,0] = Math.Round(array[i,0] * coef,2);
       array[i,1] = Math.Round(array[i,1] * coef,2);
    }
}
//-------------------------------------------------------------------------------------------------------------------+

Console.Clear();
Console.Write("Введите количество вершин: ");
int vertexes = int.Parse(Console.ReadLine()?? "");

double[,] coordinates = new double[vertexes,2];
int       rowsLength  = coordinates.GetLength(0);

FillArrayElements(coordinates,-10,10);// Зададим координаты вершин

Console.Write("\n" + "Введите коэффициент масштабирования: ");
double coef = double.Parse(Console.ReadLine()?? "");

Console.Write("Координаты до масштабирования равны: ");
PrintArray(coordinates);

Scaling(coordinates,coef);           // Масштабируем

Console.Write("\n" + "Координаты после масштабирования равны: ");
PrintArray(coordinates);