// Сложить числа используя рекурсию
Console.WriteLine("Hello, Seminar 9 & Recurtion!");
int sum(int n, int m)
{
    System.Console.WriteLine($"{n}  { m}");
    if (m == 0)
        return n;
    return sum(n + 1, m - 1);
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(n, m));
