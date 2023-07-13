using System;
using System.Dynamic;
using System.Transactions;



namespace Intro
{
    internal class Program
    {

		static int cheak(double a)
        {
            //double num = a;
            int i = 0;
            while (a > 0)
            {
                i++;
                a = (int)(a / 10);
            }
            return i;
        }
        static double result(double a, double b, char c)
        {
			double res = 0;
            if (c == '+')
            {
                res = a + b;
            }
            else if (c == '-')
            {
                res = a - b;
            }
            else if (c == '*')
            {
                res = a * b;
            }
            else
            {
                res = a / b;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.Title = ("Hello, World!"); // вывод в заголовке
            #region CONSOLE
            /*Console.BackgroundColor = ConsoleColor.Magenta; //цвет фона
            Console.CursorLeft = 22;                        //Положение слево
            Console.CursorTop = 5;                          //Положение сверху
            Console.Write("Привет, Мир!\n");                //Вывод на экран
            Console.Write("Привет, Мир!\n");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;     //Цвет шрифта 
            Console.Write("Привет, Мир!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Beep(1000, 700); */                      // Сигнал БИП! (Частота + продолжительность)
            #endregion CONSOLE
            #region STRING_OPERATIONS
            /*
            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            string s_age = Console.ReadLine();
            int age = Convert.ToInt32(s_age);
            Console.WriteLine("Имя/фамилия " + first_name + last_name + ", возраст " + age + " лет."); // конкатенация(сложение) строк
            Console.WriteLine(String.Format("Имя {0}, фамилия {1} возраст {2} лет", first_name, last_name, age));// ФОРМАТИРОВАНИЕ СТРОК
            Console.WriteLine($"Фамилия {last_name}, имя {first_name} возраст {age} лет."); //Интерполяция строк
            */
            #endregion STRING_OPERATIONS
            #region DATA_TYPES
            /*
            Console.WriteLine("BOOL:");
            Console.WriteLine(sizeof(bool));
            Console.WriteLine("CHAR:");
            Console.WriteLine(sizeof(char)); // Unocode (UTF-16)

            Console.WriteLine(Convert.ToInt32(Char.MinValue));
            Console.WriteLine(Convert.ToInt32(Char.MaxValue));

            Console.WriteLine(" ------------------------ NUMERIC TYPES ------------------------ ");

            Console.WriteLine("SHORT:");
            short a = -2;
            ushort b = 2;
            Console.WriteLine(short.MinValue + "..." + short.MaxValue);

            Console.WriteLine($"Переменная типа short занимает {sizeof(short)} памяти, и принимает значение в диапозоне от {short.MinValue} до {short.MaxValue}");
            Console.WriteLine($"Переменная типа ushort занимает {sizeof(ushort)} памяти, и принимает значение в диапозоне от {ushort.MinValue} до {ushort.MaxValue}");
            Console.WriteLine($"Переменная типа int занимает {sizeof(int)} памяти, и принимает значение в диапозоне от {int.MinValue} до {int.MaxValue}");
            Console.WriteLine($"Переменная типа long занимает {sizeof(long)} памяти, и принимает значение в диапозоне от {long.MinValue} до {long.MaxValue}");
            Console.WriteLine($"Переменная типа ulong занимает {sizeof(ulong)} памяти, и принимает значение в диапозоне от {ulong.MinValue} до {ulong.MaxValue}");
            Console.WriteLine($"Переменная типа float занимает {sizeof(float)} памяти, и принимает значение в диапозоне от {float.MinValue} до {float.MaxValue}");
            Console.WriteLine($"Переменная типа double занимает {sizeof(double)} памяти, и принимает значение в диапозоне от {double.MinValue} до {double.MaxValue}");
            Console.WriteLine($"Переменная типа decimal занимает {sizeof(decimal)} памяти, и принимает значение в диапозоне от {decimal.MinValue} до {decimal.MaxValue}");
            Console.WriteLine($"Переменная типа decimal занимает {sizeof(decimal)} памяти, и принимает значение в диапозоне от {decimal.MinValue} до {decimal.MaxValue}");
          */
            #endregion DATA_TYPES
            #region TYPE_CONVERSIONS
            /*
            int a = 2;
            uint b = 3;
            //a = d; // невозможно неявно преобразовать знаковый в беззнаковый и наоборт
            a = (int)b;
            double c = 5.2;
            //a = c; .. невозможно преобразовать целочисленный в дробный и больше к меньшему
            a = (int)c;
            bool day = true;
            Console.WriteLine(Convert.ToInt32(day));
            double d = a;
            */
            #endregion TYPE_CONVERSIONS
            #region LITERALS
            /*
            Console.WriteLine((-5.3).GetType());
            Console.WriteLine(5.3.GetType());
            Console.WriteLine(5.GetType());
            Console.WriteLine(4.4m.GetType());
            */
            #endregion LITERALS



            Console.WriteLine("Задайте выражение использую Enter вместо клавиши пробел");
            // double one_n = Convert.ToDouble(Console.ReadLine());
            string one_n = Console.ReadLine();
            double one_number = Convert.ToDouble(one_n);
            //Console.CursorLeft = cheak(one_n) + 1;
            Console.CursorLeft = one_n.Length + 1;
            Console.CursorTop = 1;
            string act = Console.ReadLine();
            //Console.CursorLeft = cheak(one_n) + 3;
            Console.CursorLeft = one_n.Length + 3;
            Console.CursorTop = 1;
            char action = Convert.ToChar(act);
            // double two_n = Convert.ToDouble(Console.ReadLine());
            string two_n = Console.ReadLine();
            double two_number = Convert.ToDouble(two_n);
            double res = result(one_number, two_number, action);
            //Console.CursorLeft = cheak(one_n) + cheak(two_n) + 3;
            Console.CursorLeft = one_n.Length + two_n.Length + 3;
            Console.CursorTop = 1;
            Console.WriteLine($" = {res}");
            


            Console.WriteLine("--------------------- ReadKey -------------------------");

            
			Console.WriteLine("Нажмите клавишу для команды или q для выхода");
            //char sumble = Console.ReadKey().KeyChar;
            char i = Console.ReadKey().KeyChar;
            while (i == 23)
            {
                if (i ==  22 || i == 22) { Console.WriteLine("Вперед"); }
            }

            // Console.WriteLine("Спасибо за участие");








        }
    }
}