/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.WriteLine("Hello, Seminar 9 & Recurtion!");
int Ackermann (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if(numberN == 0) return Ackermann(numberM - 1, 1);
    else if(numberM > 0 && numberN > 0) return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
return Ackermann(numberM, numberN);
}
System.Console.WriteLine(Ackermann(3,2));

