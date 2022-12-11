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

static double AreaTriangle(double x1, double y1, double x2, double y2,
double x3, double y3, bool enableLogging = false)
{
    double area = 0.5 * ((x2 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3));
    if (area < 0)
        area *= -1;
    if (enableLogging)
    {
        System.Console.WriteLine("x1 = " + x1);
        System.Console.WriteLine("y1 = " + y1);
        System.Console.WriteLine("x2 = " + x2);
        System.Console.WriteLine("y2 = " + y2);
        System.Console.WriteLine("x3 = " + x3);
        System.Console.WriteLine("y3 = " + y3);
        System.Console.WriteLine("Area of triangle = " + area);
    }
    return area;
}

AreaTriangle(2, 1, 2, 4, 6, 1, true);
//вывод на консоль можно убрать 

