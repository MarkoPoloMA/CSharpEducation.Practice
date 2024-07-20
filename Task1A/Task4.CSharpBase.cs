using System;

namespace Task4A
{
    class ClassTask4
    {
        public static void Main()
        {
            Console.WriteLine("Введите ваше имя: ");
            string myName = Console.ReadLine();


            Console.WriteLine("Введите сколько Вам лет: ");
            string myAge = Console.ReadLine();

            Console.WriteLine($"Ваше имя - {myName}. Вам {myAge}");

            Console.ReadKey();
        }
    }
}
