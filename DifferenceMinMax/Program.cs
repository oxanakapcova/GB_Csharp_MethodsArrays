/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.WriteLine("Hello, Arrays && Methods!");
static double[] GetRandomArray(uint Length)
{
    double[] yourarray = new double[Length];
    Random random = new Random();
    for (int i = 0; i < yourarray.Length; i++)
        yourarray[i] = random.NextDouble();
    return yourarray;
}

static double DifferentMaxMin(double[] yourarray)
{
    double minValue = yourarray[0];
    double maxValue = yourarray[0];
    for (int i = 1; i < yourarray.Length; i++)
    {
        if (yourarray[i] < minValue)
            minValue = yourarray[i];
        else if (yourarray[i] > maxValue)
            maxValue = yourarray[i];
    }
    double different = maxValue - minValue;
    return different;
}
double[] myarray = GetRandomArray(5);
//генерируются числа до 1!!!!
Console.WriteLine($"Your array is: [{string.Join("| ", myarray)}]");
double result = DifferentMaxMin(myarray);
Console.WriteLine("Result is:" + result);
