/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите 
количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте 
для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
Console.WriteLine("Hello, Array & Methods!");
static int[] GetRandomArray(uint Length, int minValue, int maxValue)
{
    int[] myarray = new int[Length];
    Random random = new Random();
    for (int i = 0; i < myarray.Length; i++)
    {
        myarray[i]= random.Next(minValue, maxValue);
    }
    return myarray;
}
int []curArray = GetRandomArray(123,-999, 1000);
int result = 0;
for (int i = 0; i < curArray.Length ; i++)
{
    if (curArray[i]>9 && curArray[i]<100)
    result+=1;
 
}
System.Console.WriteLine(result);

