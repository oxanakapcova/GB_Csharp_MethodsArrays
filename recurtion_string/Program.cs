// Собрать строку с числами от а до b, a<=b
Console.WriteLine("Hello, Recurtion & Methods!");
static string NumberFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
        result += $"{i} ";
    return result;
}//without recurtion
System.Console.WriteLine(NumberFor(1, 10));

static string NumberRec(int a, int b)
{
    if (a <= b)
        return $"{a} " + NumberRec((a + 1), b);
    else return string.Empty;
}
System.Console.WriteLine(NumberRec(11, 21));