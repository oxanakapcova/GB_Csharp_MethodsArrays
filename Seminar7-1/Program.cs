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

static void InPutMethod(int[,]yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
       for (int j = 0; j < yourArray.GetLength(1); j++)
       {
        yourArray[i,j]= i+j;
        System.Console.Write(yourArray[i,j]+"\t");
       } 
       System.Console.WriteLine();
    }
}
InPutMethod(anyArray);










