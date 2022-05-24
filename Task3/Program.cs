void PrintArray(int[] array)
{
    int length = array.Length;
    foreach(int item in array)
        Console.Write($"{item} ");
}
//---------------------------------------------------------------------------------------------------+

// Написать программу копирования массива
Console.Clear();
Console.WriteLine("Создадим массив и заполним его элементами: ");

int[]  mainArray     = new int[30];
int    mLength       = mainArray.Length;
int[]  arrayReceiver = new int[mLength];
Random rnd           = new Random();

for (int i = 0; i < mLength; i++) // запонили главный массив
    mainArray[i] = rnd.Next(-1000,1000);

Console.WriteLine("Главный массив после заполнения:");
PrintArray(mainArray);
Console.WriteLine("\n" + "Массив приемник до заполнения:");
PrintArray(arrayReceiver);

for (int j = 0; j < mLength; j++) // копируем массив
   arrayReceiver[j] = mainArray[j]; 

Console.WriteLine();
Console.WriteLine("\n" + "Массив приемник после заполнения:");
PrintArray(arrayReceiver);