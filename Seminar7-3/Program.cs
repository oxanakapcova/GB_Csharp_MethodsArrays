/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
Console.WriteLine("Hello, Two-dimensional arrays & Methods!");
static void InputArray(int[,] yourArray)
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
static void SumDiagonal(int[,] yourArray)
{
    int sum = 0;
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            if (i == j)
                sum += yourArray[i, j];
        }
    }
        System.Console.WriteLine("Sum is: "+ sum);
}
int [,]anyArray = new int [6,5];
InputArray(anyArray);
PrintArray(anyArray);
System.Console.WriteLine("=========================================");
SumDiagonal(anyArray);








