/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double b1, b2, k1, k2, x, y;
System.Console.WriteLine("Enter b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter b2: ");
b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter k2: ");
k2 = Convert.ToDouble(Console.ReadLine());
//k1*x+b1=k2*x+b2
//k1*x-k2*x=b2-b1
//(k1-k2)*x = b2-b1
x = (b2-b1)/(k1-k2);
y = k1*x + b1;
System.Console.WriteLine("x = "+x+", y = "+y);
