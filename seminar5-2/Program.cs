/*
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/
Console.WriteLine("Hello, Arrays && Methods!");
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}
string ReleaseArray(int[] array, int yourValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == yourValue)
            return "yes";
    }
    return "no";
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int amountElements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[amountElements];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число, которое Вы хотите найти в массиве: ");
int yourValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, yourValue));

