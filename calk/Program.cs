Console.WriteLine("Введите первое число: "); //ввод первого числа
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число число: "); //ввод второго числа
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Знак математической операции: "); //ввод знака мат. операции
string znak = Convert.ToString(Console.ReadLine());

{
    
    if (znak == "/")
    {
        Console.Write("Ответ: ");
        Console.WriteLine(a / b);

    }
    else
    if (znak == "*")
    {
        Console.Write("Ответ: ");
        Console.WriteLine(a * b);

    }
    else
    if (znak == "+")
    {
        Console.Write("Ответ: ");
        Console.WriteLine(a + b);

    }
    else
    if (znak == "-")
    {
        Console.Write("Ответ: ");
        Console.WriteLine(a - b);

    }
        else
        {
            Console.Write("Ответ: Введен не корректный знак операции ");
        }
    

}