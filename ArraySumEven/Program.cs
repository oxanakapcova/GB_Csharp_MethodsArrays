/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Hello, Arrays && Methods!");
static int[] GetRandomArray(uint Length, int minValue, int maxValue)
{
    int[] yourarray = new int[Length];
    Random random = new Random();
    for (int i = 0; i < yourarray.Length; i++)
        yourarray[i] = random.Next(minValue, maxValue);
    return yourarray;
}

static int SumEvenNumbers(int[] yourarray)
{
    int result = 0;
    for (int i = 0; i < yourarray.Length; i++)
    {
        if (yourarray[i] % 2 == 0)
        {
            result += yourarray[i];
        }
    }
    return result;
}

int[] myarray = GetRandomArray(10, 100, 1000);
System.Console.WriteLine(($"Исходный массив: [{string.Join(", ", myarray)}]"));

int result = SumEvenNumbers(myarray);
System.Console.WriteLine();
System.Console.WriteLine(result);
