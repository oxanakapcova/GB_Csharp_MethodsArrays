Console.Clear();
Console.WriteLine("Hello, Methods!");
static void PrintResult(int result)
{
    System.Console.WriteLine("Result is:\t" + result);
}
static int Sum(int value_1, int value_2)
{
    return value_1 + value_2;
}
int a, b;
System.Console.WriteLine("Enter value 1:\t");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter value 2:\t");
b = Convert.ToInt32(Console.ReadLine());

PrintResult(Sum(a, b));