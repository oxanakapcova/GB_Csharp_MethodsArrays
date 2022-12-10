// необязательные параметры метода
Console.WriteLine("Hello, Methods & Enable Logging!");
static int Sum(int a, int b, bool enableLogging = false)
{//необязательному параметру обязательно присваиваем значение
    int result = a + b;
    if (enableLogging)
    {
        System.Console.WriteLine("first value a = " + a);
        System.Console.WriteLine("second value b = " + b);
        System.Console.WriteLine("sum is: " + result);
    }
    return result;
}
Sum(3, 9, true);
//если при вызове не указывать необязательный параметр то он по умолчанию
//false