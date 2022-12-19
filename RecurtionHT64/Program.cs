/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4,5, 6, 7, 8"
*/
Console.WriteLine("Hello, Seminar 9 & Recurtion!");
static uint Numbers(uint numberMin, uint numberMax)
{
    System.Console.Write($"{numberMin} ");
    if (numberMin == numberMax) return numberMax;
    else return Numbers(numberMin + 1, numberMax);

}
Numbers(1, 9);

