/* вывести числа в двумерном массиве по диагонали
0 1 3 6 9 12 15
2 4 7 10 13 16 18
5 8 11 14 17 19 20
*/

static void InPutArray(int[,] yourArray)
{
    int value = 0;
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            yourArray[i, j] = value;
            value += 1;
        }
    }
}
static void PrintArray(int[,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
            System.Console.Write(yourArray[i, j] + "\t");
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Enter matrix size n and m via space: ");
string[]numbers = Console.ReadLine().Split(" ");
int[,] anyArray = new int[int.Parse(numbers[0]),int.Parse(numbers[1])];
System.Console.WriteLine("========================================");

int n = anyArray.GetLength(0);
int m = anyArray.GetLength(1);
int i = 0, j = 0;
int p = 0, counter = -1;
int size = n * m;
int c = 1;

while (counter < size)
{
    if (j >= 0 && j < m && i < n)
    {
        anyArray[i, j] = counter;
    }
    else if (p < m)
    {
        i = 0;
        j = p;
        p++;   // счетчик для сдвига вправо
        anyArray[i,j] = counter;
    }
    else if (p == m)
    {
        i = c;
        c++;
        j = m - 1;
        anyArray[i,j] = counter;
    }
    i++;
    j--;
    counter++;
}
PrintArray(anyArray);
