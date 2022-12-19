
Console.WriteLine("Hello, Factorial & Recurtion!");

double Factorial(int value)
{
    if (value == 1) return 1;
    else return value * Factorial(value - 1);
}
Console.WriteLine(Factorial(5));

static double FactorialFor(int a)
{
    double result = 1;
    for (int i = 1; i <= a; i++)
        result *= i;
    return result;
}
System.Console.WriteLine(FactorialFor(3));