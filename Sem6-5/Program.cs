/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
Console.WriteLine("Hello, Seminar 6!");
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int x, a0 = 0, a1 = 1;//0,1,и следующее неизвестное значение
for (int i = 0; i < value; i++)
{
    Console.Write($"{a0} ");
    x = a0 + a1;
    a0 = a1;
    a1 = x;
}

