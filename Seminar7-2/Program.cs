/*
Задача 49: Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные, и замените эти элементы на
их квадраты.
Например, изначально массив
выглядел вот так:
Новый массив будет выглядеть
1 4 7 2
5 9 2 3
8 4 2 4
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/
Console.WriteLine("Hello, Seminar 7 and arrays!");
// task 48


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
                matrix[i, j] *= matrix[i, j];

            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Результат: ");
ReleaseMatrix(matrix);


