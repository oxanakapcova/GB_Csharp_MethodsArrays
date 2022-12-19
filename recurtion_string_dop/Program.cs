// Cобрать строку с числами от а до b, a>=b
Console.WriteLine("Hello, Recurtion & Methods!");
static string NumberFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
        result += $"{i} ";
    return result;
}
System.Console.WriteLine(NumberFor(10, 0));

static string NumberRec(int a, int b)
{
if (a>=b)
    return $"{a} " + NumberRec(a-1,b);
    return string.Empty;
}
System.Console.WriteLine(NumberRec(20,10));