/* keyword REF
Console.WriteLine("Hello, Ref && Methods && Arrays!");
static void Bar(int[] myarray)
{
    myarray[0] = -5;
}//метод присваивает первому элементу значение -5
int[] array = { 1, 4, 6 };
Bar(array);

ref int b = ref array[0];
b = -6;

//static ref int Foo(int[] yourarray)
{

    return ref yourarray[0];
}
//ref int b = ref Foo(array);
код не запускать!!! показан синтаксис
*/