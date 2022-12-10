/*Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;//вместо пробела
while (value > 0)
{
    result = Convert.ToString(value % 2) + result;
    value /= 2;
}
Console.WriteLine(result);

