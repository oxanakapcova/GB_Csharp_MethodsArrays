// Найти сумму элементов массива с помощью рекурсии
Console.WriteLine("Hello, Recurtion & Arrays!");
static int SumElements(int[] yourArray, int i = 0)
{
    if (i >= yourArray.Length)
        return 0;//без значения код не скомпилируется а условие выхода
                 //необходимо, 0 не повлияет на алгоритм нахождения суммы
    int result = SumElements(yourArray, i + 1);
    return yourArray[i]+result;
}//return yourArray[i]+SumElements(yourArray,i+1)
int[] anyArray = { 1, 2, 3, 4, 5, 6 };
int result = SumElements(anyArray);
System.Console.WriteLine(result);
/*метод вначале вызывает сам себя и складывает в стэк значения всех
индексов по порядку пока не доходит до значения указанного как выход
из рекурсии и тогда в стек попадает 0, после этого начинает отрабатывать
строка 9 и все складывается начиная с 0  потом последний элемент и по
порядку пока не пройдет самый первый: 0+6+5+4+3+2+1
сумма сохраняется в переменную result и передается методом
*/