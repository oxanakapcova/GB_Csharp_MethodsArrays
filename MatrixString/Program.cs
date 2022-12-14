/*
Входной файл INPUT.TXT содержит 4 строки по 4 символа «W» или «B» в 
каждой, описывающие узор из плиток. Символ «W» обозначает плитку белого
цвета, а «B» - черного.
Выходные данные
В выходной файл OUTPUT.TXT выведите «Yes», если узор является 
симпатичным и «No» в противном случае.
Примеры
INPUT.TXT	OUTPUT.TXT
BWBW
BBWB
WWBB
BWWW	     Yes

BBWB
BBWB
WWBW
BBWB	     No
*/
Console.WriteLine("Hello, Seminar 7 & two-dimensional arrays!");
string[,] myRoom = new string[4, 4];
static void InPutString(string[,] yourString)
{
    for (int i = 0; i < yourString.GetLength(0); i++)
    {
        Random random = new Random();
        string[]WB = {"W","B"};
        for (int j = 0; j < yourString.GetLength(1); j++)
            yourString[i, j] =WB[new Random().Next(2)];
    }
}
static void PrintString(string[,] yourString)
{
    for (int i = 0; i < yourString.GetLength(0); i++)
    {
        for (int j = 0; j < yourString.GetLength(1); j++)
            System.Console.Write(yourString[i, j] + "\t");
        System.Console.WriteLine();
    }
}
InPutString(myRoom);
PrintString(myRoom);