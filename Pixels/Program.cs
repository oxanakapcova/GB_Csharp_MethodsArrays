/*
Входные данные
Первая строка входного файла INPUT.TXT содержит целые числа n и m 
(1 ≤ n, m ≤ 100) – высоту и ширину исходного изображения (в пикселях). 
Последующие n строк содержат описание исходного изображения. Каждая 
строка состоит из m символов «B» и «W». Символ «B» соответствует 
черному пикселю, а символ «W» – белому. Далее следует пустая строка, а 
после нее – описание выведенного Мишиной программой изображения в том 
же формате, что и исходное изображение.
Выходные данные
В выходной файл OUTPUT.TXT необходимо вывести число пикселей негатива, 
которые неправильно сформированы Мишиной программой.
Примеры
INPUT.TXT	OUTPUT.TXT
	3 4
WBBW          2
BBBB
WBBW

BWWW
WWWB
BWWB	
	2 2
BW            2
BB

WW
BW	
*/
Console.WriteLine("Hello, Pixels & multidimensional arrays!");

static void InPutString(string[,] yourString)
{
    for (int i = 0; i < yourString.GetLength(0); i++)
    {
        Random random = new Random();
        string[] WB = { "W", "B" };
        for (int j = 0; j < yourString.GetLength(1); j++)
            yourString[i, j] = WB[new Random().Next(2)];
    }
}

static void PrintString(string[,] yourString)
{
    for (int i = 0; i < yourString.GetLength(0); i++)
    {
        for (int j = 0; j < yourString.GetLength(1); j++)
            System.Console.Write(yourString[i, j] + " ");
        System.Console.WriteLine();
    }
}


static void Compare(string[,] firstString, string[,] secondString)
{
    int amount = 0;
    for (int i = 0; i < firstString.GetLength(0); i++)
    {
        for (int j = 0; j < secondString.GetLength(1); j++)
        {
            if (firstString[i, j] == secondString[i, j])
                amount += 1;
        }
    }
    System.Console.WriteLine((amount));
}
string[,] anyString = new string[3, 4];
InPutString(anyString);
PrintString(anyString);
System.Console.WriteLine();
string[,] mishaString = new string[anyString.GetLength(0), anyString.GetLength(1)];
InPutString(mishaString);
PrintString(mishaString);
Compare(anyString, mishaString);