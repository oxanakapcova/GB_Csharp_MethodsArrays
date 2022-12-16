// заполнение матрицы числами от 0 до....по порядку
Console.WriteLine("Hello, Two-dimensional arrays!");
static void InPutSnake(int[,]yourArray)
{
    int count =0;//значение на позиции [0,0]
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            yourArray[i,j]=count;
            count+=1;//увеличение
        }
    }
}
static void PrintArray(int[,]yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
            System.Console.Write(yourArray[i,j]+"\t");
        System.Console.WriteLine();
    }
}
int [,]anyArray = new int [3,6];
InPutSnake(anyArray);
PrintArray(anyArray);