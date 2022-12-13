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
/*
static void InputArray(string[,] pixels)
{
    for (int i = 0; i < pixels.GetLength(0); i++)
    {
        Random random = new Random();
        for (int j = 0; j < pixels.GetLength(1); j++)
            pixels[i, j] = Convert.ToString(random.Next("B","W" +1));
    }
}
*/
static void PrintArray(string[,]pixels)
{
    for (int i = 0; i < pixels.GetLength(0); i++)
    {
        for (int j = 0; j < pixels.GetLength(1); j++)
            System.Console.Write(pixels[i,j]+" ");
        System.Console.WriteLine();
    }
}
string[,]anystring = Console.ReadLine().Split(string.Empty);


PrintArray(anystring);
