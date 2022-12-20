// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Seminar 9 & Recurtion!");
int sum()
{//внутри функции вводим число и прибавляем пока не введется 0
int x = Convert.ToInt32(Console.ReadLine());
if (x == 0)
return 0;
return sum() + x;
}
Console.WriteLine(sum());
