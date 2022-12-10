
Console.WriteLine("Hello, Factorial & Recurtion!");

double Factorial(int value)
{
 // 1! = 1
 // 0! = 1
 if(value == 1) return 1;
 else return value * Factorial(value-1);
}
for (int i = 1; i < 40; i++)
{
 Console.WriteLine(Factorial(i));
}//число +Е29 = число * 10 в степени 29