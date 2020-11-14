using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Введите пятизначное число:");
            int.TryParse(Console.ReadLine(), out num);
            if (num > 9999 && num < 100000)
            {
                Console.WriteLine($"1 цифра равна{num / 10000}");
                Console.WriteLine($"2 цифра равна{(num / 1000) % 10}");
                Console.WriteLine($"3 цифра равна{(num / 100) % 10}");
                Console.WriteLine($"4 цифра равна{(num / 10) % 10}");
                Console.WriteLine($"5 цифра равна{num % 10}");
            }
            else
            {
                if (num <= 9999)
                    Console.WriteLine("Ваше число меньше пятизначного!");
                if (num >= 100000)
                    Console.WriteLine("Ваше число больше пятизначного!");
            }

            int max = num % 10; 
            num = num / 10;
            do
            {
               if (num % 10 > max)
                   max = num % 10;
               num = num / 10;               
            }
            while (num > 0);

            Console.WriteLine($"Максимальная цифра:{max}");
        }
    }
}
