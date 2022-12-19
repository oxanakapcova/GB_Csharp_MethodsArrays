/*
Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.
*/
Console.WriteLine("Hello, Two-dimensional arrays!");
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
static int MinValue(int[,] yourArray)
{
    int minValue = yourArray[0, 0];
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            if (yourArray[i, j] < minValue)
                minValue = yourArray[i, j];
        }
    }
    return minValue;
}
static int IndexOff(int[,] yourArray, int value)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        int minRow = 0; int minColumn = 0;
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            if (yourArray[i, j] == value)
            {
                minRow = i;
                minColumn = j;
            }
        }
        
    }
    return -1;//если числа не найдет
}
int[,] anyArray = new int[4, 6];
InPutArray(anyArray);
PrintArray(anyArray);
int result = MinValue(anyArray);
System.Console.WriteLine("========================================");
System.Console.WriteLine(result);
int index = IndexOff(anyArray, result);
System.Console.WriteLine(index);