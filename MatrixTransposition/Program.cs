/*
Задана целочисленная матрица, состоящая из N строк и M столбцов. 
Требуется транспонировать ее относительно горизонтали.
Входные данные
Первая строка входного файла INPUT.TXT содержит два натуральных числа N
и M – количество строк и столбцов матрицы. В каждой из последующих N 
строк записаны M целых чисел – элементы матрицы. Все числа во входных 
данных не превышают 100 по абсолютной величине.
Выходные данные
В выходной файл OUTPUT.TXT выведите матрицу, полученную 
транспонированием исходной матрицы относительно горизонтали.
Пример
INPUT.TXT	3,4
5 9 2 6
6 2 4 3
1 2 8 7	
OUTPUT.TXT
1 2 8 7
6 2 4 3
5 9 2 6
*/
Console.WriteLine("Hello, Matrix transposition and arrays!");
static void InputArray(int[,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        Random random = new Random();
        for (int j = 0; j < yourArray.GetLength(1); j++)
            yourArray[i, j] = random.Next(100);
    }
}
static void PrintArray(int[,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
            Console.Write(yourArray[i, j] + "\t");
        System.Console.WriteLine();
    }
}
static void Transposition(ref int[,] yourArray)
{
    int[,] newArray = new int[yourArray.GetLength(0), yourArray.GetLength(1)];
    for (int i = yourArray.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
            Console.Write(yourArray[i, j] + "\t");
        System.Console.WriteLine();
    }
    yourArray = newArray;
}//используем ключевое слово ref
int[,] anyArray = new int[4, 4];
InputArray(anyArray);
PrintArray(anyArray);
System.Console.WriteLine("========================================");
Transposition(ref anyArray);
