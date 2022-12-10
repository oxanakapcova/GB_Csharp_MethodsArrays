
Console.WriteLine("Hello, Matrix & multidimensional Arrays!");
void PrintArray(int[,] matr)
{//метод вывода на консоль
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{//метод заполнения случайными числами
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}
int[,] matrix = new int[3, 14];
PrintArray(matrix);//вывели
FillArray(matrix);//заполнили
Console.WriteLine();
PrintArray(matrix);//опять вывели
