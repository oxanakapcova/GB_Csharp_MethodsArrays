/* вывести числа в двумерном массиве по диагонали
0 1 3 6 9 12 15
2 4 7 10 13 16 18
5 8 11 14 17 19 20
*/

static void Diagonal(int[,] yourArray, int row, int column)
{
    int[,] mas = new int[4, 10];
    Random random = new Random();
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 10; j++)
            if (i == j)
            {
                mas[i, j] = i;//вот эта строчка                     }                     else                         mas[i, j] = r.Next(11, 15);               }
            }
    }
}