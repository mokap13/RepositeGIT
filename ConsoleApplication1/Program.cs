using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArithmeticTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаем длительность игры
            TimeSpan duration = new TimeSpan(0,0,60);

            //Диапазон случайных значений
            const int MIN = 2;
            const int MAX = 99;
            const int MAX_MULT = 10;

            //Генератор случайных чисел
            Random random = new Random(DateTime.Now.Millisecond);

            //Результат и очки
            int result = 0;
            int points = 0;

            char[] signs = {'+','-','*','/'};
            bool error = false;
            string s; //Ответ пользователя

            Console.WriteLine("Нажмите любую клавишу для начала игры");
            Console.ReadKey();

            //Засекаем время 
            DateTime start = DateTime.Now;
            DateTime end = start + duration;

            while (DateTime.Now < end)
            {
                //Генерируем случайные операторы и числа
                char op = signs[random.Next(signs.Length)];
                int a = random.Next(MIN, MAX);
                int b = random.Next(MIN, MAX);
                int answer;

                switch (op)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '-':
                        if (a == b)
                        {
                            b = random.Next(MIN, MAX);
                        }
                        result = a - b;
                        break;
                    case '*':
                        if (a > MAX_MULT)
                        {
                            a = random.Next(MIN, MAX_MULT);
                        }
                        if (b > MAX_MULT)
                        {
                            b = random.Next(MIN, MAX_MULT);
                        }
                        result = a * b;
                        break;
                    case '/':
                        if (a < b)
                        {
                            int c = a;
                            a = b;
                            b = c;
                        }
                        if (a % b != 0)
                        {
                            a = b * (a / b);
                        }
                        result = a / b;
                        break;
                }

                Console.WriteLine(a.ToString() + op + b.ToString() + " = ");
                s = Console.ReadLine();

                if (int.TryParse(s, out answer))
                {
                    if (result == answer)
                    {
                        points++;
                        Console.WriteLine("Верно!");
                    }
                    else
                    {
                        Console.WriteLine("Не верно :( ");
                        Console.WriteLine("Правильный ответ = " + result);
                    }
                }
                else
                {
                    Console.WriteLine("Не корректный ответ!");
                }
                Console.WriteLine("Всего очков -> " + points);
            }

            Console.WriteLine("Время истекло! Игра окончена");

            string FileName = "archive.txt";
            string[] content;
            int record = 0;

            if (File.Exists(FileName))
            {
                content = File.ReadAllLines(FileName);

                record = int.Parse(content[0]);

                if (record >= points)
                {
                    Console.WriteLine("Последний рекорд {0} от {1}",record,content[1]);
                }
            }

            if (!File.Exists(FileName) || record < points)
            {
                Console.WriteLine("Поздравляем вы установили новый рекорд");
                content = new string[2];
                record = points;

                content[0] = record.ToString();
                content[1] = DateTime.Now.ToString();
                File.WriteAllLines(FileName, content);
            }
            Console.ReadKey();
        }
    }
}
