/*
Задача 45: Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.

Console.WriteLine("Hello, Methods & Arrays!");
static int[] GetRandomArray(uint Length, int minValue, int maxValue)
{
    int[] yourarray = new int[Length];
    Random random = new Random();
    for (int i = 0; i < yourarray.Length; i++)
        yourarray[i] = random.Next(minValue, maxValue);
    return yourarray;
}
int []myarray = GetRandomArray(5,1,11);
static void Copy<T>(ref T[] yourarray, int newSize)
{//<T>generic будет работать с любым типом данных
    T[] newArray = new T[newSize];
    for (int i = 0; i < yourarray.Length && i < newArray.Length; i++)

    {

        newArray[i] = yourarray[i];//копируем каждый элемент в новый
    }//массив, остальные заполнятся дефолтными значениями
    yourarray = newArray;//ссылка 
}
*/
Console.Clear();
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];
for (int i = 0; i < a.Length; i++)
    b[i] = a[i];
b[0] = 5;
Console.WriteLine(string.Join(", ", a));
Console.WriteLine(string.Join(", ", b));
