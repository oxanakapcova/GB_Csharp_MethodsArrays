/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 9
[6 7 3 6] -> 36 21
*/
Console.WriteLine("Hello, World!");
// task 35

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 11);
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);

