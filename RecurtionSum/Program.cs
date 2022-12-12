// Найти сумму элементов массива с помощью рекурсии
Console.WriteLine("Hello, Recurtion & Arrays!");
static int SumElements(int[] yourarray, int i = 0,
bool enableLogging = false)
{
    int sum = 0;
    if (yourarray[i] < yourarray.Length)
    {
        sum += yourarray[i];
        SumElements(yourarray, i + 1);
    }
     if (enableLogging)
        Console.WriteLine("Sum of elements is: " + sum);
    return sum;
}
int[] anyarray = { 1, 2, 3, 4, 5, 6 };
SumElements(anyarray, 0, true);
