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
void FillArrayElement(double[,] array, int index, double valueX,double valueY)
{
    Random rnd = new Random();
    array[index,0] = Math.Round(rnd.NextDouble()*valueX,2);
    array[index,1] = Math.Round(rnd.NextDouble()*valueY,2);
}
//-----------------------------------------PrintArray----------------------------------------------------------------+
void PrintArray(double[,] array)
{
    int length = array.Length/2;
    for (int i = 0; i < length; i++)
    {
       Console.Write($"({array[i,0]};{array[i,1]}) " );
    }
}
//-------------------------------------------------------------------------------------------------------------------+

double[,] coordinates     = new double[4,2];
int       firstAreaLength = coordinates.Length/2;

// Расположим точки в разных координатных плоскостях
FillArrayElement(coordinates,0,10,10);
FillArrayElement(coordinates,1,10,-10);
FillArrayElement(coordinates,2,-10,-10);
FillArrayElement(coordinates,3,-10,10);

Console.Clear();
Console.Write("\n" + "Введите коэффициент масштабирования: ");
double coef = double.Parse(Console.ReadLine()?? "");

Console.Write("Координаты до масштабирования равны: ");
PrintArray(coordinates);

// Масштабируем
for (int i = 0; i < firstAreaLength; i++)
{
    coordinates[i,0] *= coef;
    coordinates[i,1] *= coef;
}

Console.Write("\n" + "Координаты после масштабирования равны: ");
PrintArray(coordinates);