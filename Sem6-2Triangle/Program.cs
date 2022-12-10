/*
Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон.
*/
Console.WriteLine("Hello, Seminar 6 & Methods!");
int a, b, c;
System.Console.WriteLine("Enter a:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter c:");
c = Convert.ToInt32(Console.ReadLine());
if (a > b + c && b > a + c && c > a + b)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

