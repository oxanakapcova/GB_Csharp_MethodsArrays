/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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


static int SumOddIndex(int[] yourarray)
{
    int result = 0;
    for (int i = 1; i < yourarray.Length; i=i+2)
    {
        result+=yourarray[i];
    }
    return result;
}
int[] myarray = GetRandomArray(7, -9, 10);
Console.WriteLine($"Your array is: [{string.Join(", ", myarray)}]");
int result = SumOddIndex(myarray);
System.Console.WriteLine("Result is:"+result);