/*Задача 63: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
Console.WriteLine("Hello, Recurtion & Methods!");
static void NumberRec(int valueFirst, int valueSecond)
{
    System.Console.Write($"{valueFirst} ");
    if (valueFirst >= valueSecond)
        return;//остановит цикл при срабатывании условия
    valueFirst++;//если условие выхода не будет то выйдет ошибка переполнения стека
    NumberRec(valueFirst, valueSecond);//рекурсия
}
NumberRec(1, 5);
