/*
Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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



void sortDescending(int[,] yourArray)
{
  
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            for (int k = 0; k < yourArray.GetLength(1) - 1; k++)
            {
                if (yourArray[i, k] < yourArray[i, k + 1])
                {
                    int temp = yourArray[i, k + 1];
                    yourArray[i, k + 1] = yourArray[i, k];
                    yourArray[i, k] = temp;
                }
            }
        }
    }
}
int[,] anyArray = new int[3, 5];
InPutArray(anyArray);
PrintArray(anyArray);
sortDescending( anyArray);
System.Console.WriteLine("====================================");
PrintArray(anyArray);
Console.ReadLine();
//третий цикл создан для возможности сравнивать актуальное значение и
//стоящее рядом, логика обычная как в одномерном массиве