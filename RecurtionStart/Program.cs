// метод вызывает сам себя в методе
Console.WriteLine("Hello, Recurtion!");
static void Foo(int i)
{
    System.Console.WriteLine(i);
    if (i >= 3)
        return;//остановит цикл при срабатывании условия
    i++;//если условие выхода не будет то выйдет ошибка переполнения стека
    Foo(i);//рекурсия
}
Foo(0);