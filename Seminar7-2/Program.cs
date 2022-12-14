/*
Задача 49: Задайте двумерный массив. Найдите элементы,у которых оба 
индекса нечётные, и замените эти элементы на их квадраты.Например, 
изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/
Console.WriteLine("Hello, Seminar 7 and arrays!");
static void InputArray(int[,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        Random random = new Random();
        for (int j = 0; j < yourArray.GetLength(1); j++)
            yourArray[i, j] = random.Next(11);
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
static void SquareNumber(int[,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
                yourArray[i, j] *= yourArray[i, j];
//значение умножаем на значение
            Console.Write(yourArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] anyArray = new int[5, 3];
InputArray(anyArray);
PrintArray(anyArray);
System.Console.WriteLine("===================================");
SquareNumber(anyArray);
