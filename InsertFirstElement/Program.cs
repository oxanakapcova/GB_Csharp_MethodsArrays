// Написать методы для добавления элемента в начало массива.
Console.WriteLine("Hello, Ref & Methods!");
static void InsertFirstElements(ref int[] yourarray, int value)
{
    int[] newArray = new int[yourarray.Length + 1];
    newArray[0] = value;
    for (int i = 1; i < newArray.Length; i++)
    {
        newArray[i] = yourarray[i - 1];
    }
    yourarray = newArray;
}
int[] anyarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
InsertFirstElements(ref anyarray, -100);
System.Console.WriteLine($"[{string.Join(", ", anyarray)}]");

