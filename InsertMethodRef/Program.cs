/*
Написать методы для добавления элемента в начало массива, в конец 
массива и по указанному индексу.
это универсальный метод для любого индекса, отдельно напишу для 
добавления в начало InsertFirstElements и конец InsertLastElements
для оптимизации
*/
Console.WriteLine("Hello, Ref & Methods & Arrays & Generic!");
static void Insert(ref int[] yourarray, int value, int index)
{//подходит для любого указанного индекса
    int[] newArray = new int[yourarray.Length + 1];
    newArray[index] = value;//поместили заданное значение в заданный индекс
    for (int i = 0; i < index; i++)
        newArray[i] = yourarray[i];
    for (int i = index + 1; i < newArray.Length; i++)
    {
        newArray[i] = yourarray[i - 1];
    }
    yourarray = newArray;
}
int[] anyArray = { 1, 2, 3, 4, 5, 6 };
Insert(ref anyArray, 99, 3);
System.Console.WriteLine($"[{string.Join(", ", anyArray)}]");

static void AddFirst( ref int[] yourarray, int value)
{
    Insert(ref yourarray, value, 0);
}
int[] array = {1,2,3,4,5,6,7,8};
AddFirst(ref array, 99);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

static void AddLast(ref int[] yourarray, int value)
{
    Insert(ref yourarray, value, yourarray.Length);
}
AddLast(ref array, 222);
System.Console.WriteLine($"[{string.Join(", ",array)}]");