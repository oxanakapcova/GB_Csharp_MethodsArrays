Console.WriteLine("Hello, Seminar 7 & multidimensional arrays!");
/*
Задача 48: Задайте двумерный массив размера m на
n, каждый элемент в массиве находится по формуле:
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4
0 1 2 3
1 2 3 4
2 3 4 5
*/
System.Console.WriteLine("Enter amount of rows and columns: ");
string[] numbers  = Console.ReadLine().Split(" ");
//массив строк, указан разделитель
int row = Convert.ToInt32(numbers[0]);//1 введенный элемент
int column = Convert.ToInt32(numbers[1]);//2 введенный элемент
int [,] anyArray = new int [row,column];











/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
*/
