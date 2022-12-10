/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.WriteLine("Hello, Arrays && Methods!");
static double[] GetRandomArray(uint Length, double minValue, double maxValue)
{
    double[] yourarray = new double[Length];
    Random random = new Random();
    for (int i = 0; i < yourarray.Length; i++)
        yourarray[i] = Math.Round((random.NextDouble() * (maxValue - minValue) + minValue), 2);
        //чтобы выводились числа более 1
        //Math.Round( a, 2)число покажет сколько цифр после запятой
        //выводить чтоб не было так много как без нее
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
double[] myarray = GetRandomArray(5, 10, 100);
Console.WriteLine($"Your array is: [{string.Join("| ", myarray)}]");
double result = DifferentMaxMin(myarray);
Console.WriteLine("Result is:" + result);

/*
решение педагога
int i = 0;
while (i <= 10)
{
// * (end - begin) + begin
double val = new Random().NextDouble() * (10 - 1) + 1; // [0, 1]
Console.WriteLine(Math.Round(val, 2));
i++;
}
*/
/*
Console.Clear();
int i = 0;
while (i <= 10)
{
// * (end - begin) + begin
double val = new Random().NextDouble() * (10 - 1) + 1; // [0, 1]
Console.WriteLine(Math.Round(val, 2));
i++;
}
*/