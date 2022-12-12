/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("Hello, Seminar 7 & Multidimentional Arrays!");
static void InputArray(double[,] yourarray)
{
    for (int i = 0; i < yourarray.GetLength(0); i++)
    {
        Random random = new Random();
        for (int j = 0; j < yourarray.GetLength(1); j++)
            yourarray[i, j] = Math.Round(random.NextDouble() * (99 - 1) + 1, 2);
    }
}//заполнили массив
static void PrintArray(double[,] yourarray)
{
    for (int i = 0; i < yourarray.GetLength(0); i++)
    {
        for (int j = 0; j < yourarray.GetLength(1); j++)
        {
            Console.Write(yourarray[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}//вывели массив на консоль
double[,] anyarray = new double[3, 4];
InputArray(anyarray);
PrintArray(anyarray);
