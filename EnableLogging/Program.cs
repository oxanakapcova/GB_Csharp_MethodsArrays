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
Sum(b: 5, a: 3, enableLogging: true);
//если при вызове не указывать необязательный параметр то он по умолчанию
//false
//именнованные параметры а:5 и тд помогают легче читать код и 
// указывают точное расположение переменных