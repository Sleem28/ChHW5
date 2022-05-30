/*
Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/

//-------------------------------------------------------------------------------------------------------------------+
int[,] FillPoints(string[] arrPoints)
{
    int[,] points = new int[arrPoints.Length,2];

    for (int i = 0; i < arrPoints.Length; i++)
    {
        string substring = arrPoints[i].Substring(1,arrPoints[i].Length-2);
        string[] arrSubstrings = substring.Split(",");
        points[i,0] = int.Parse(arrSubstrings[0]);
        points[i,1] = int.Parse(arrSubstrings[1]);
        
    }

    return(points);
}
//-------------------------------------------------------------------------------------------------------------------+
void MultipleCoordinates(int[,] points, int coef)
{
    for (int i = 0; i < points.GetLength(0); i++)
    {
        points[i,0] *= coef;
        points[i,1] *= coef;
    }
}
//-------------------------------------------------------------------------------------------------------------------+
void PrintResult(int[,] points)
{
    for (int i = 0; i < points.GetLength(0); i++)
    {
        Console.Write($"({points[i,0]},{points[i,1]}) ");
    }
    Console.WriteLine();
}
//-------------------------------------------------------------------------------------------------------------------+
Console.Clear();
Console.Write("Введите координаты: ");
string   sCoordinates   = Console.ReadLine()?? "";
Console.Write("Введите коэффициент масштабирования: ");
int coef = int.Parse(Console.ReadLine()?? "");

string[] arrCoordinates = sCoordinates.Split(" ");
int[,]   points         = FillPoints(arrCoordinates);
MultipleCoordinates(points,coef);
Console.Write("Координаты после масштабирования равны: ");
PrintResult(points);




