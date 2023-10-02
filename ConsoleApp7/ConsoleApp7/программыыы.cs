using System;

namespace games
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Привет! Выбери программку:>");
            Console.WriteLine("1: Игра ~угадай число~");
            Console.WriteLine("2: Таблица умножения");
            Console.WriteLine("3: Делители числа");
            Console.WriteLine("Нажми 0 если захочешь выйти");

            while (true)
            {
                int vibor = Convert.ToInt32(Console.ReadLine());
                if (vibor == 1)
                {
                    vibor1();
                }
                if (vibor == 2)
                {
                    vibor2();
                }
                if (vibor == 3)
                {
                    vibor3();
                }
                if (vibor == 0)
                {
                    vibor0();
                    break;
                }
            }
        }

        static void vibor1()
        {
            Random rand = new Random();
            int num = rand.Next(0, 100);
            while (true)
            {
                Console.WriteLine("Пробуй отгадать число от 1 до 100! Я подсказываю:>");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > num)
                {
                    Console.WriteLine("перебарщиваешь!");
                }
                else if (input < num)
                {
                    Console.WriteLine("маловато будет!");
                }
                else if (input == num)
                {
                    Console.WriteLine("ура! правильно!");
                    break;
                }

            }
            Console.WriteLine("Привет! Выбери программку:>");
            Console.WriteLine("1: Игра ~угадай число~");
            Console.WriteLine("2: Таблица умножения");
            Console.WriteLine("3: Делители числа");
            Console.WriteLine("Нажми 0 если захочешь выйти");
        }

        static void vibor2()
        {
            Console.WriteLine("На таблицу умножения");
            for (int m = 1; m <= 10; m++)
            {
                for (int n = 1; n <= 10; n++)
                {
                    Console.Write(m * n + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Привет! Выбери программку:>");
            Console.WriteLine("1: Игра ~угадай число~");
            Console.WriteLine("2: Таблица умножения");
            Console.WriteLine("3: Делители числа");
            Console.WriteLine("Нажми 0 если захочешь выйти");
        }

        static void vibor3()
        {
            Console.WriteLine("Введи число, а я выведу все его делители");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " " + "\n");
                }
            }

            Console.WriteLine("Привет! Выбери программку:>");
            Console.WriteLine("1: Игра ~угадай число~");
            Console.WriteLine("2: Таблица умножения");
            Console.WriteLine("3: Делители числа");
            Console.WriteLine("Нажми 0 если захочешь выйти");
        }

        static void vibor0()
        {
            Console.WriteLine("До встречи <3");
        }
    }
}

