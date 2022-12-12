/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента или 
же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такой позиции в массиве нет
*/
Console.WriteLine("Hello, Seminar 7 & multidimensional arrays!");
static void InputArray(int[,] yourArray)
{
    Random random = new Random();
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
            yourArray[i, j] = random.Next(100);
    }
}
static void PrintArray(int[,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            System.Console.Write(yourArray[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
static void ReturnPosition(int[,] yourArray, int row, int column)
{
    if (row > yourArray.GetLength(0) || column > yourArray.GetLength(1))
        Console.WriteLine("No position here.\nTry again!");
    else
        Console.WriteLine("Your position is: " + yourArray[row, column]);
}
int[,] anyArray = new int[3, 4];
InputArray(anyArray);
PrintArray(anyArray);
ReturnPosition(anyArray, 4, 1);
