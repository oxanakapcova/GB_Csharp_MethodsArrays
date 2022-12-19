// метод возведения числа а в степень n
Console.WriteLine("Hello, Recurtion and Methods!");
static uint PowerFor(uint a, uint n)
{
    uint result = 1;
    for (int i = 1; i <= n; i++)
        result *= a;
    return result;
}
System.Console.WriteLine(PowerFor(2, 3));

static uint PowerRec(uint a, uint n)
{
    if (n == 0)
        return 1;
    else return PowerRec(a, n - 1) * a;
}
System.Console.WriteLine(PowerRec(3, 3));

static uint PowerRecMath(uint a, uint n)
{//оптимизация кода!!!!
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
System.Console.WriteLine(PowerRecMath(2,6));