using System;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово!");
            String word = Console.ReadLine();
            switch (word)
            {
                case "мяу":
                    Console.WriteLine("Покорми кота!");
                    break;
                case "гав":
                    Console.WriteLine("Погуляй с собакой!");
                    break;
                default:
                    Console.WriteLine("я не знаю таких животных");
                    break;
            }
        }
    }
}
