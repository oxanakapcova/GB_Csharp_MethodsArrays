/*
Написать метод для поиска индекса элемента массива (тип элементов в 
массиве -int), метод должен вернуть индекс первого найденного элемента 
(если он будет найден).
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, My Method Find arrays index!");
        
        static int FindIndex(int[] myarray, int Value)
        { //метод ищет в массиве индекс указанного числа
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] == Value)
                    return i;
            }
            return -1;//если числа нет
        }
        System.Console.WriteLine("============================");
        static int[] GetRandomArray(uint Length, int minValue, int maxValue)
        { //метод заполняет массив рандомными числами
            int[] myarray = new int[Length];
            Random random = new Random();
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = random.Next(minValue, maxValue);
            }
            return myarray;
        }
        int[] FindNumber = GetRandomArray(10, -10, 10);//создан массив заполненный случайными числами с помощью метода 
        int result = FindIndex(FindNumber, 5);
        System.Console.WriteLine(result);

        System.Console.WriteLine();
    }
}