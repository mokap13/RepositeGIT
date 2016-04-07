using System;
using System.IO.Ports;
using System.Threading;

namespace ExamSoftwareEngin
{
    class Program
    {
        static Random random = new Random();//Генератор случайных чисел(общий для всех задач)

        static ConsoleKeyInfo keyState = new ConsoleKeyInfo();//Состояние клавиши

        delegate void del();

        static void Main(string[] args)
        {
            int choose; //Выбор пользователя
            while (true)
            {
                #region Вывод меню на экран
                //Меню программы
                Console.Title = "Введение в программную инженерию";
                Console.WriteLine(@"Курсовая работа по предмету «Введение в ПИ», 
на тему: «Программирование базовых алгоритмических задач»");
                Console.WriteLine("---------------------------------------------------------\n");
                Console.WriteLine("Выберите задачу");
                Console.WriteLine(@"1)Массивы
2)Математический расчет
3)Проверка на истинность логического выражения
4)Проверка координаты на принадлежность определенной области на плоскости
5)Ветвление");
                Console.WriteLine("---------------------------------------------------------\n");
                #endregion

                #region Ввод и валидация введенной пользователем команды
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out choose) == false || choose < 1 || choose > 5)
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                #region Ветвление программы
                switch (choose)
                {
                    case (1):
                        Form(new del(Arrays), "Массивы");
                        break;
                    case (2):
                        Form(new del(CalcMathTasks), "Математический расчет");
                        break;
                    case (3):
                        Form(new del(LogicExpressions), "Проверка на истинность логического выражения");
                        break;
                    case(4):
                        Form(new del(SquareLogicExpressions), "Проверка координаты");
                        break;
                    case(5):
                        Form(new del(Branches), "Ветвление");
                        break;
                }
                #endregion 

                Console.Clear();//Обновление экрана
            }
        }

        /// <summary>
        /// 7)Дан массив целых чисел а0,...,аn-1. 
        /// Найти количество и сумму тех членов данного массива,
        /// которые делятся на 5 и не делятся на 7.
        /// </summary>
        static void Arrays()
        {
            //Константы для настройки генератора случайных чисел
            const int MIN = 1;
            const int MAX = 99;

            const int SIZE_ARRAY = 15;//Размер массива
            int[] arr = new int[SIZE_ARRAY];
            int counter = 0;//Счетчик кол-ва отобранных по условию чисел
            int total = 0;//Сумма отобранных по условию чисел

            //Выводим исходный массив
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < SIZE_ARRAY; i++)
            {
                arr[i] = random.Next(MIN, MAX);
                Console.Write(arr[i] + "  ");
            }
            
            //Выводим обработанный массив
            Console.WriteLine("\nОбработанный массив:");
            for (int i = 0; i < SIZE_ARRAY; i++)
            {
                //Условие отбора чисел
                if (arr[i] % 5 == 0 && arr[i] % 7 != 0)
                {
                    counter++;
                    total += arr[i];
                    Console.Write(arr[i] + "  ");
                }
            }

            //Вывод результата
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nКоличество элементов удовлетворяющих условию  " + counter);
            Console.WriteLine("Сумма элементов удовлетворяющих условию  " + total);
            Console.ResetColor();
        }
        /// <summary>
        /// 17)Найти площадь треугольника, две стороны которого равны а и b, а угол между этими сторонами γ. 
        /// </summary>
        static void CalcMathTasks()
        {
            //Константы для настройки генератора случайных чисел
            const int MIN_SIDE = 1;//Минимальное значение стороны
            const int MAX_SIDE = 20;//Максимальное значение стороны
            const int MIN_ANGLE = 10;//Минимальное значение угла
            const int MAX_ANGLE = 180;//Макасимальное значение угла

            int sideA = 0;//Значение стороны А
            int sideB = 0;//Значение стороны B
            int angleAB = 0;//Угол между сторонами A и B
            double angleRadAB = 0;//Угол в радианах
            double sinY = 0;//Синус угла
            double square = 0;//Площадь
            //Присваеваем случайные числа
            sideA = random.Next(MIN_SIDE, MAX_SIDE);
            sideB = random.Next(MIN_SIDE, MAX_SIDE);
            angleAB = random.Next(MIN_ANGLE, MAX_ANGLE);

            //Выводим на экран исходные значения
            Console.WriteLine("Сторона А = " + sideA);
            Console.WriteLine("Сторона B = " + sideB);
            Console.WriteLine("Угол между сторонами А и В в градусах = " + angleAB);

            //Рассчитываем и выводим угол в радианах
            angleRadAB = angleAB * Math.PI / MAX_ANGLE;
            Console.WriteLine("Угол в радианах " + angleRadAB);

            //Рассчитываем и выводим синус угла AB
            sinY = Math.Sin(angleRadAB);
            Console.WriteLine("Синус угла = " + sinY);

            //Рассчитываем и выводим значение площади
            square = (sideA*sideB*sinY)/2;
            Console.Write("Площадь данного треугольника = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(square);
            Console.ResetColor();
        }
        /// <summary>
        /// 17)Цифры данного четырехзначного числа N образуют строго возрастающую последовательность. 
        /// </summary>
        static void LogicExpressions()
        {
            int number;//Число

            //Значение разрядов числа
            int thousand;
            int handred;
            int ten;
            int one;
            //Константы для настройки генератора случайных чисел
            const int MIN = 1000;
            const int MAX = 9999;
            
            number = random.Next(MIN, MAX);
            Console.WriteLine(number);

            //Вычисляем разряды числа(тысячи и сотни)
            thousand = (number - number % 1000) / 1000;
            handred = (number - thousand * 1000 - number % 100) / 100;
                
            //Проверяем условие
            if (thousand < handred)
            {
                //Вычисляем разряд десяток
                ten = (number - thousand * 1000 - handred * 100 - number % 10) / 10;
                //Проверяем условие
                if (handred < ten)
                {
                    //Вычисляем разряд единиц
                    one = number - thousand * 1000 - handred * 100 - ten * 10;
                    if (ten < one)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("************************");
                        Console.WriteLine("==-->> " + thousand + "  " + handred +
                                          "  " + ten + "  " + one + " <<--==");
                        Console.WriteLine("************************");
                        Console.WriteLine("Цифры данного числа образуют возрастающую последовательность \a");
                        Console.ReadLine();
                        Console.ResetColor();
                    }
                }
            }  
        }
        /// <summary>
        /// 17)Для данных областей составить линейную программу, которая печатает true,
        /// если точка с координатами (х, у) принадлежит закрашенной области,
        /// и false — в противном случае: 
        /// </summary>
        static void SquareLogicExpressions()    
        {
            //Константы для настройки генератора случайных чисел
            const int MIN = -9;
            const int MAX = 9;

            int x, y;
            x = random.Next(MIN, MAX);
            y = random.Next(MIN, MAX);
            
            //Условия при которых точка принадлежит заданной области
            if (y <= x + 5 && y >= -x - 5 && y >= x - 5 && y * y <= 25 - x * x)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Координаты точки : {0}  {1}\a", x, y);
                Console.WriteLine(true);
                Console.ResetColor();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Координаты точки : {0}  {1}", x, y);
                Console.WriteLine(false);
            }
        }
        /// <summary>
        /// 17)Написать программу — модель анализа пожарного датчика в помещении,
        /// которая выводит сообщение «Пожароопасная ситуация»,
        /// если температура в комнате превысила 60° С. 
        /// </summary>
        static void Branches()
        {
            //Инициализируем последовательный порт
            SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            int sizeBuff = 1;
            byte[] buff = new byte[sizeBuff];
            string str;
            int value;

            Console.Clear();
            //Считываем из порта данные
            port.Read(buff,0,1);
            str = Convert.ToInt16(buff[0]).ToString();
            Console.WriteLine(str);
            value = int.Parse(str);
            if (value < 10)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(">>>>ВНИМАНИЕ!!! в здании пожар, как можно быстрее покиньте здание<<<<");
                Console.ResetColor();
            }
            port.Close();
        }
        /// <summary>
        /// Форма для вывода задачи на экран с повтором выполнения
        /// </summary>
        /// <param name="ChoosedFunc">Указатель на выбранный пользователем метод</param>
        /// <param name="TitleFunc">Название выбранной задачи</param>
        static void Form(del ChoosedFunc,string TitleFunc)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(TitleFunc);
            while (true)
            {
                ChoosedFunc();//Переданный метод
                Console.WriteLine("\n");
                Console.WriteLine(@"Для повторения решения задачи нажмите ""ПРОБЕЛ""
Для выхода в меню нажмите любую другую клавишу");
                Console.WriteLine("---------------------------------------------------------");

                //Ожидание нажатся какой-либо клавиши
                keyState = Console.ReadKey();

                //Возрат каретки для эстетичности визуализации данных на экране
                Console.WriteLine("\r");
                
                //Условия для выхода из цикла
                if (keyState.Key != ConsoleKey.Spacebar)
                {
                    return;
                }
            }
        }
    }
}

