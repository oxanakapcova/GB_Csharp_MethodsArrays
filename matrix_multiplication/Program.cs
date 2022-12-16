/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
*/
Console.WriteLine("Hello, Two-dimensional arrays!");
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

static int[,] Multiplication(int[,] yourArray, int[,] anyArray)
{

    int[,] newArray = new int[yourArray.GetLength(0), yourArray.GetLength(1)];
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            newArray[i, j] = yourArray[i, j] * anyArray[i, j];
        }
    }

    return newArray;
}
int[,] firstArray = new int[3, 3];
int[,] secondArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
InPutArray(firstArray);
InPutArray(secondArray);
PrintArray(firstArray);
System.Console.WriteLine("=======================================");
PrintArray(secondArray);
int[,] resultArray = Multiplication(firstArray, secondArray);
System.Console.WriteLine("======================================");
PrintArray(resultArray);