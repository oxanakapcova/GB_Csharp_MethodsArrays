/*
Написать метод Resize изменяющий количество элементов массива (метод 
должен иметь возможность увеличить или уменьшить количество элементов 
массива).
Array.Resize() под капотом
*/
Console.WriteLine("Hello, Methods, Arrays,loops, Ref & Generics!");

static void Resize<T>(ref T[] yourarray, int newSize)
{//<T>generic будет работать с любым типом данных
    T[] newArray = new T[newSize];
    for (int i = 0; i < yourarray.Length && i < newArray.Length; i++)
    {
        newArray[i] = yourarray[i];//копируем каждый элемент в новый
    }//массив, остальные заполнятся дефолтными значениями
    yourarray = newArray;//ссылка 
}
double[] myarray = { 1.5, 2.3, 3.4, 4.025, 5, 6 };
Resize(ref myarray, 10);//вызов метода
System.Console.WriteLine($"[{string.Join(", ", myarray)}]");


