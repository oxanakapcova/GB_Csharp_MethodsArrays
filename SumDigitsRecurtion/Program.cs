/* программа считает сумму цифр числа, метод рекурсия
Console.WriteLine("Hello, recursion!");
static int SumDigits(int yourValue)
{
    if (yourValue < 10)
        return yourValue;
    int digit = yourValue % 10;
    int intermediateValue = yourValue / 10;
    return digit + SumDigits(intermediateValue);
}
int myValue = 12345;
int result = SumDigits(myValue);
System.Console.WriteLine(result);
/*переменные созданы для удобства и понятия, можно записать так:
if (yourValue < 10)
    return yourValue;
return yourValue % 10 + SumDigits(yourValue / 10);
сложение будет производится рекурсивно когда произойдет условие 
выхода из рекурсии
*/
static int SumDigits(int value)
{
    if (value < 10)
        return value;
    int digit = value % 10;
    int intermediateValue = value / 10;
    return digit + SumDigits(intermediateValue);
}
System.Console.WriteLine(SumDigits(1235));