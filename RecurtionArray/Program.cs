// Реализовать вывод массива с помощью рекурсии
Console.WriteLine("Hello, Recurtion & Methods!");
int[] anyarray = { 1, 2, 3, 4, 5, 6 };
static void PrintArray(int[] yourArray, int i = 0)
{//                                    необязательный параметр
    if (yourArray[i] < yourArray.Length)
    {
        System.Console.WriteLine(yourArray[i]);
        PrintArray(yourArray, i + 1);
    }
}
PrintArray(anyarray,2);
//необязательный параметр по умолчанию 0, но можно это исправить