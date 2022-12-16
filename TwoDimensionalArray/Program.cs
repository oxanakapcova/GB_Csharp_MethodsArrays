/*
Задача 53: Задайте двумерный массив. Напишите программу, которая 
поменяет местами первую и последнюю строку массива.
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
static void Change(int[,] yourArray)
{
    for (int j = 0; j < yourArray.GetLength(1); j++)
    {
        int a = yourArray[0, j];
        int b = yourArray[yourArray.GetLength(0) - 1, j];
        yourArray[0, j] = b;
        yourArray[yourArray.GetLength(0) - 1, j] = a;
    }

}
int[,] myArray = new int[5, 4];
InPutArray(myArray);
PrintArray(myArray);
Change(myArray);
System.Console.WriteLine("=====================================");
PrintArray(myArray);