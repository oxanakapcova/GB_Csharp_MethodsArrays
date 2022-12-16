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
static void InputArray(int[,] yourArray)
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
static void ArithmeticMean(int[,] yourArray)
{
    for (int j = 0; j < yourArray.GetLength(1); j++)
    {//вначале перебираем по вертикали
        double sum = 0;
        for (int i = 0; i < yourArray.GetLength(0); i++)
        {
            sum += yourArray[i, j];
        }
        Console.WriteLine($"{j+1} result is: [{string.Join(", ",Math.Round(sum / yourArray.GetLength(0),2))}]");
    }//j+1 для красоты и понимания, но можно оставить отсчет с 0
}
int[,] anyArray = new int[3, 5];
InputArray(anyArray);
PrintArray(anyArray);
ArithmeticMean(anyArray);
Console.ReadLine();

