using System;

namespace Task1A
{
    class ClassTask3
    {
       public static void Main()
        {
            Console.WriteLine("Введите ваше имя: ");
            string myName = Console.ReadLine();

            Console.WriteLine($"Ваше имя - {myName}. Привет {myName}");

            Console.ReadKey();
        }
    }
}
