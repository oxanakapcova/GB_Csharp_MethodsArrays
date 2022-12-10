//Написать метод для добавления элемента в конец массива.
Console.WriteLine("Hello, Ref & Methods!");
static void InsertLastElements(ref int[] yourarray, int value)
{
    int[] newArray = new int[yourarray.Length + 1];
    for (int i = 0; i < yourarray.Length; i++)
    {
        newArray[i] = yourarray[i];
    }
    newArray[newArray.Length - 1] = value;
    yourarray = newArray;
}
int[] anyarray = { 1, 2, 3, 4, 5, 6 };
InsertLastElements(ref anyarray, -100);
System.Console.WriteLine($"[{string.Join(", ", anyarray)}]");
