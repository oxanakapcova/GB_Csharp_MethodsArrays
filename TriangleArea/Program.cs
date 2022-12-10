/*
Площадь треугольника
По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и 
(x3,y3) требуется вычислить его площадь.
Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – 
координаты вершин треугольника. Все числа не превышают 106 по 
абсолютной величине.
В выходной файл OUTPUT.TXT выведите точное значение площади заданного 
треугольника.
Примеры
№	INPUT.TXT	   OUTPUT.TXT
1	2 1 2 4 6 1	   6
2	0 0 0 3 3 0	   4.5
*/
Console.WriteLine("Hello, Area of Triangles!");

System.Console.WriteLine("Enter x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
double area = 0.5 * ((x2 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3));
if (area < 0)
    area *= -1;
System.Console.WriteLine("================\n" + area);
