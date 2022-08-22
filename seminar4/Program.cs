using System;

namespase ConsoleApp1
{   
     class Program
    {
        static void ReadNumber(int number)   //создание функции
        {
            Console.WriteLine(number * number);
        }
        static string WriteNumber(int number)
        {
            return number % 2 == 0 ? "Кратное" : "Не кратное";
        }
        /*static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
             ReadNumber(number);     
             Console.WriteLine(WriteNumber(number));
        }
    }*/
    }
}
