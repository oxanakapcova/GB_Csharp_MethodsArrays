/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("Hello, Two-dimensional arrays & Methods!");
static void InPutArray(int[,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        Random random = new Random();
        for (int j = 0; j < yourArray.GetLength(1); j++)
            yourArray[i, j] = random.Next(100);
    }
}
static void PrintArray(int[,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
            System.Console.Write(yourArray[i, j] + "\t");
        System.Console.WriteLine();
    }
}

static int SumRow(int[,] yourArray, int numberrow)
{
    int sum = 0;
    for (int j = 0; j < yourArray.GetLength(1); j++)
    {
        sum += yourArray[numberrow, j];
    }

    return sum;
}
int[,] anyArray = new int[3, 5];
InPutArray(anyArray);
PrintArray(anyArray);
int result = SumRow(anyArray, 1);
System.Console.WriteLine("======================================");
System.Console.WriteLine(result);
