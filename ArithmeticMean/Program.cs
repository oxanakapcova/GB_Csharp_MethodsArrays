/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.WriteLine("Hello, Seminar 7 & Multidimensional arrays!");
static void InputArray(int[,]yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        Random random = new Random();
        for (int j = 0; j < yourArray.GetLength(1); j++)
           yourArray[i,j]= random.Next(100);
    }
}
static void PrintArray(int[,]yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
            System.Console.Write(yourArray[i,j]+"\t");
        System.Console.WriteLine();
    }
}
static double ArithmeticMean(int[,]yourArray)
{
    double result = 0;
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        
    }

    return result;
}
int[,]anyArray = new int [3,4];
InputArray(anyArray);
PrintArray(anyArray);