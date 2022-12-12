/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Hello, Seminar 6!");

System.Console.WriteLine("Enter amount of numbers:");
uint amount = Convert.ToUInt32(Console.ReadLine());
uint countPositive = 0;
for (uint i = 1; i <= amount; i++)
{
    Console.WriteLine("Enter your number: ");
    if (Convert.ToInt32(Console.ReadLine()) > 0)//без переменной
        countPositive += 1;
}
System.Console.WriteLine("=========================\n" + countPositive);