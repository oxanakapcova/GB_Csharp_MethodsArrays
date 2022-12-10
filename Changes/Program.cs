/*
Перестановки
Дана строка, состоящая из N попарно различных символов. Требуется 
вывести все перестановки символов данной строки.
Входной файл INPUT.TXT содержит строку, состоящую из N символов 
(1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры.
В выходной файл OUTPUT.TXT выведите в каждой строке по одной 
перестановке. Перестановки можно выводить в любом порядке. Повторений и
строк, не являющихся перестановками исходной, быть не должно.

Примеры
№	INPUT.TXT	     OUTPUT.TXT
1	AB	             AB
                     BA
2	IOX	             XOI
                     OIX
                     IXO
                     XIO
                     OXI
                     IOX
*/
Console.WriteLine("Hello, Strings & Recursion!");
//количество перестановок равно факториалу элементов массива
static void Changes(ref char[] yourarray)
{
    char[] newArray = new char[yourarray.Length];
    newArray[0] = yourarray[1];
    newArray[1] = yourarray[0];
    yourarray = newArray;
}
char []myarray = {'A','B'};
Changes(ref myarray);
System.Console.WriteLine($"[{string.Join(", ",myarray)}]");



