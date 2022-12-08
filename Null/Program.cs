Console.Clear();
Console.WriteLine("Hello, Null!");
string str = "test";
str ??= string.Empty;//" " пустая строка
//??= заменит null  на введенное значение
//?? добавляем где надо исключить null
//?. если null то дальше исполнять не будет, можно объеденить с ?? после
//описания действия не для null

System.Console.WriteLine(str);