/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить 
массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine("Hello, Three dimensional arrays & Methods!");
static void InPutArray(int[,,] yourArray)
{
    int count = 10;
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            for (int k = 0; k < yourArray.GetLength(2); k++)
            {
                yourArray[i, j, k] = count;
                count += 1;
            }
        }
    }
}
static void PrintArray(int[,,] yourArray)
{
    for (int i = 0; i < yourArray.GetLength(0); i++)
    {
        System.Console.WriteLine("Page number: "+(i+1));
        for (int j = 0; j < yourArray.GetLength(1); j++)
        {
            for (int k = 0; k < yourArray.GetLength(2); k++)
            {
                Console.Write(yourArray[i, j, k] + "("+i+","+j+","+k+")  ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
int[,,] anyArray = new int[2, 2, 2];
InPutArray(anyArray);
PrintArray(anyArray);