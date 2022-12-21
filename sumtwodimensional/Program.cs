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
            yourArray[i, j] = random.Next(10);
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
/*
static int SumRow(int[,] yourArray, int numberrow)
{//найдет сумму элементов строки по указанному индексу
    int sum = 0;
    for (int j = 0; j < yourArray.GetLength(1); j++)
    {
        sum += yourArray[numberrow, j];
    }

    return sum;
}
*/
static void SumInRow(int[,] yourArray)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < yourArray.GetLength(1); i++)
        minRow += yourArray[0, i];
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
            sumRow += yourArray[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

int[,] anyArray = new int[3, 4];
InPutArray(anyArray);
PrintArray(anyArray);
System.Console.WriteLine("======================================");
SumInRow(anyArray);
