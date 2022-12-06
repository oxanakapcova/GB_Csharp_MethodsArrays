﻿/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите 
количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте 
для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

Console.WriteLine("Hello, Array & Methods!");
static int[] GetRandomArray(uint Length, int minValue, int maxValue)
{
    int[] myarray = new int[Length];
    Random random = new Random();
    for (int i = 0; i < myarray.Length; i++)
    {
        myarray[i] = random.Next(minValue, maxValue);
    }
    return myarray;
}
int[] yourArray = GetRandomArray(123, -999, 1000);

static int amount(int[] yourarray)
{
    int result = 0;
    for (int i = 0; i < yourArray.Length; i++)
    {
        if (yourArray[i] > 9 && yourArray[i] < 100)
            result += 1;
    }
    return result;
}
int[] myarray = GetRandomArray(10, -100, 1000);
int result = amount(myarray);
Console.WriteLine($"Your array is: [{string.Join(", ", myarray)}]");
Console.WriteLine(result);
*/

double[] GetArrayRandomNumbers(int n)
 {
    double[] array = new double[n];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Math.Round(rand.NextDouble() * (100 - (-100)) ,2);
    }
    return array;
 }
 Console.Clear();
 Console.Write("Введите кол-во элементов массива: ");
 int n = Convert.ToInt32(Console.ReadLine());
 double[] mas = GetArrayRandomNumbers(n);
 Console.WriteLine($"Исходный массив: [{string.Join(", ", mas)}]");