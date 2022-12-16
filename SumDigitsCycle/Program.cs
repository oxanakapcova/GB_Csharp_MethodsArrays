/*
Найти сумму цифр числа
512=5+1+2=8
*/
Console.WriteLine("Hello, Methods & cycles!");
static int SumDigits(int yourValue)
{
    int result = 0;
    while (yourValue > 0)
    {
        result += yourValue % 10;
        yourValue /= 10;
    }
    return result;//не забывать возвращать результат
}
int myValue = 5618;
int myResult = SumDigits(myValue);
System.Console.WriteLine(myResult);
