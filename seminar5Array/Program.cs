/*
Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
чисел равна 29, сумма отрицательных равна -20.
*/
Console.WriteLine("Hello, Seminar 5!");

// task 31

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}


void ReleaseArray(int[] array)
{
    int sumPositive = 0, sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }
    Console.WriteLine($"Сумма положительных чисел в массиве {sumPositive}");
    Console.WriteLine($"Сумма отрицательных чисел в массиве {sumNegative}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);


