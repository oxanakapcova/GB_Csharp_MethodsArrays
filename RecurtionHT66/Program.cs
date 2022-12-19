/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Hello, Seminar 9 & Recurtion!");
static uint SumRec(uint minValue, uint maxValue)
{
    if (maxValue > minValue)
        return maxValue + SumRec(minValue, maxValue - 1);
    else return minValue;
}
System.Console.WriteLine(SumRec(2,5));
