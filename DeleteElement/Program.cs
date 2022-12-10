/*
написать методы для удаления первого, последнего и элемента по указанному
индексу. Ключевое слово ref
*/
Console.WriteLine("Hello, Ref & Methods!");
static void DeleteElement(ref int[] yourarray, int index)
{//универсальный метод
    int[] newarray = new int[yourarray.Length - 1];
    for (int i = 0; i < index; i++)
        newarray[i] = yourarray[i];
    for (int i = index + 1; i < yourarray.Length; i++)
        newarray[i - 1] = yourarray[i];
    yourarray = newarray;
}
int[] myarray = { 1, 2, 3, 4, 5, 6 };
DeleteElement(ref myarray, 4);
System.Console.WriteLine($"[{string.Join(", ", myarray)}]");
//Урра все получилось
//удалит первый элемент [0]
static void DeleteFirst(ref int[]yourarray)
{
DeleteElement(ref yourarray, 0);
}
DeleteFirst(ref myarray);
System.Console.WriteLine($"[{string.Join(", ",myarray)}]");
//удалит последний элемент
static void DeleteLast(ref int[]yourarray)
{
DeleteElement(ref yourarray, yourarray.Length - 1);
}
DeleteLast(ref myarray);
System.Console.WriteLine($"[{string.Join(", ",myarray)}]");