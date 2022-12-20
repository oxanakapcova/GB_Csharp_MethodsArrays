// Собрать строку с числами от а до b, a<=b
//вывести числа от 1 до n
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

static string NumRec(int n)
{
if (n == 1)
return "1 ";//возвращаем строку!!!
return NumRec(n - 1) + $"{n} ";
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumRec(n));
