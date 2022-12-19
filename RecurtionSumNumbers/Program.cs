// сумма чисел от 1 до n
Console.WriteLine("Hello, Recurtion & Methods!");
static int SumRec(int a)
{
    if (a == 0)
        return 0;
    return a + SumRec(a - 1);
}
System.Console.WriteLine(SumRec(5));

static int SumFor(int a)
{
    int result = 0;
    for (int i = 1; i <=a; i++)
        result +=i;
    return result;
}
System.Console.WriteLine(SumFor(10));
