﻿/*
Написать функцию которая выводит на экран строку. Символы из которых 
состоит строка и их количество вводятся пользователем.
*/
Console.WriteLine("Hello, My Method String!");
static void MyString(string symbol, uint symbolCount)
{

    for (int i = 0; i < symbolCount; i++)
    {
        System.Console.Write(symbol);
    }

}
System.Console.WriteLine("=======================");
System.Console.WriteLine("Enter symbols: ");
string symbol  = Console.ReadLine()??"no data";
symbol ??= String.Empty;//or "no data"
//если придет значение null
Console.WriteLine("Enter how many time to repeat: " ?? "no data");
uint symbolCount = Convert.ToUInt32(Console.ReadLine());
MyString(symbol, symbolCount);

//Ура получилось!!!!!