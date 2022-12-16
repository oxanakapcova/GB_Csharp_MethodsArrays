/*
Задача 55: Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы. В случае, если это невозможно, программа 
должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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
static void Change(ref int[,] matrix, int row, int column)
{
    if (row != column)
        System.Console.WriteLine("Yo're wrong, try again!");
    else
    {
        int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newmatrix[i, j] = matrix[j, i];
            }
        }
        matrix = newmatrix;
    }
}

int[,] matrix = new int[4, 4];
InPutArray(matrix);
PrintArray(matrix);
System.Console.WriteLine("=================================");
Change(ref matrix, 4, 4);
PrintArray(matrix);

