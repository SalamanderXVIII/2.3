using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.3. 2-й вариант, высокий уровень, Гребенюк.
            Console.WriteLine("Введите характер ветра: ");
            string x = (Console.ReadLine());
            switch (x)
            {
                case "слабый": Console.WriteLine("Скорость ветра: 1-4м/с"); break;
                case "умеренный": Console.WriteLine("Скорость ветра: 5-10м/с"); break;
                case "сильный": Console.WriteLine("Скорость ветра: 9-18м/с"); break;
                case "ураганный": Console.WriteLine("Скорость ветра: больше 19м/с"); break;
            }
        }
    }
}
