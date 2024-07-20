using System;

namespace Task3A
{
    class ClassTask3
    {
        public static void Task3()
        {
            Console.WriteLine("Введите ваше имя: ");
            string myName = Console.ReadLine();

            Console.WriteLine($"Ваше имя - {myName}. Привет {myName}");

            Console.ReadKey();
        }
    }
}
