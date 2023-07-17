using System;
using System.Dynamic;
using System.Transactions;



namespace TaskLvl1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region TASK_2
			/*
			Console.WindowWidth = 125;
			Console.WriteLine($"Тип данных 'short' занимает {sizeof(short)} байт и принимает значение в диапозоне от {short.MinValue} до {short.MaxValue} .");
			Console.WriteLine($"Тип данных 'int' занимает {sizeof(int)} байт и принимает значение в диапозоне от {int.MinValue} до {int.MaxValue} .");
			Console.WriteLine($"Тип данных 'double' занимает {sizeof(double)} байт и принимает значение в диапозоне от {double.MinValue} до {double.MaxValue} .");
			Console.WriteLine($"Тип данных 'long' занимает {sizeof(long)} байт и принимает значение в диапозоне от {long.MinValue} до {long.MaxValue} .");
			Console.WriteLine($"Тип данных 'ushort' занимает {sizeof(ushort)} байт и принимает значение в диапозоне от {ushort.MinValue} до {ushort.MaxValue} .");
			Console.WriteLine($"Тип данных 'ulong' занимает {sizeof(ulong)} байт и принимает значение в диапозоне от {ulong.MinValue} до {ulong.MaxValue} .");
			#endregion TASK_2
			Console.Write("Введите сумму: ");
			decimal money = Convert.ToDecimal(Console.ReadLine());
			int grn = (int)money;
			int cop = (int)((money - grn) * 100);
			Console.WriteLine($"{grn} грн. {cop} коп.");
			*/
			#endregion TASK_2
			#region TASK_3
			/*
			Console.WriteLine("Ввидете кол-во тетрадей: ");
			double n = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ввидете кол-во обложек: ");
			double n_1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ввидете кол-во комплектов: ");
			int n_2 = Convert.ToInt32(Console.ReadLine());
			*/
			#endregion TASK_3
			#region TASK_4
			/*
			Console.WriteLine("Ввидите выражение: ");
			string expression = Console.ReadLine(); // читает !строку! с клавиатуры 
			expression = expression.Replace('.', ',');  
			//Replace('что заменить', 'чем заменить') заменяет первый символ на второй символ
			// в данном случае заменяем запятую на точку
			String[] values = expression.Split(new char[] { '+', '-', '*', '/' });  
			// метод split(разделяет строку на подстроки, по указаным разделителям) 
			// Split() принимает массив char, в котором перечислены разделители, и возвращает массив строк (токенов)
			//метод split не изменяет исходную строку.

			double a = Convert.ToDouble(values[0]);
			double b = Convert.ToDouble(values[1]);

			//Метод Contains() проверяет, содержит ли указаная строка базовую подстроку
			if (expression.Contains('+')) Console.WriteLine($"{a} + {b} = {a + b}");
			else if (expression.Contains('-')) Console.WriteLine($"{a} - {b} = {a - b}");
			else if (expression.Contains('*')) Console.WriteLine($"{a} * {b} = {a * b}");
			else if (expression.Contains('/')) Console.WriteLine($"{a} / {b} = {a / b}");
			else Console.WriteLine("No operation");
			*/
			#endregion TASK_4
			#region TASK_5
			/*
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.S: Console.WriteLine("Назад"); break;
					case ConsoleKey.W: Console.WriteLine("Вперед"); break;
					case ConsoleKey.A: Console.WriteLine("Влево"); break;
					case ConsoleKey.D: Console.WriteLine("Вправо"); break;
					case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
					case ConsoleKey.Enter: Console.WriteLine("Огонь"); Console.Beep(); break;

					default: Console.WriteLine("Error"); break;
				}
			} while (key != ConsoleKey.Escape);
			*/
			#endregion TASK_5


			Console.Title = ("Играй в Змейку (1.1 Beta)");

			Console.BufferHeight = Console.WindowHeight + 1;
			Console.BufferWidth = Console.WindowWidth + 1;
			//Console.WriteLine($"Windows: {Console.WindowWidth} {Console.WindowHeight}");
			//Console.WriteLine($"Buffer: {Console.BufferWidth} {Console.BufferHeight}");
			Console.SetCursorPosition(2, 0);
			Console.WriteLine($"1)Правила");
			Console.SetCursorPosition(2, 1);
			Console.WriteLine($"2)Начать игру");
			Console.SetCursorPosition(2, 2);
			Console.WriteLine($"3)Управления");
			Console.SetCursorPosition(2, 5);
			Console.WriteLine("4)Завершить игру");
			Console.SetCursorPosition(48, 28);
			Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");



			//Положения яблока
			Random rand = new Random();
			int x_fud = rand.Next(Console.WindowWidth - 1);
			int y_fud = rand.Next(1, Console.WindowHeight - 1);
			// Кол во яблок
			int fud = 0;
			// Положение змейки
			int x = 60;
			int y = 15;
			//Console.CursorVisible = true;
			ConsoleKey key;
			do
			{

				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.D1:
						Console.Clear();
						Console.Beep(400, 150);
						Console.SetCursorPosition(2, 0);
						Console.WriteLine($"1)Правила");
						Console.SetCursorPosition(2, 1);
						Console.WriteLine($"2)Начать игру");
						Console.SetCursorPosition(2, 2);
						Console.WriteLine($"3)Управления");
						Console.SetCursorPosition(2, 5);
						Console.WriteLine("4)Завершить игру");
						Console.SetCursorPosition(30, 0);
						Console.WriteLine("Для победы сьешьте 20 яблок");
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");
						break;
					case ConsoleKey.D2:
						Console.Clear();
						Console.Beep(400, 150);
						Console.WriteLine("Для старта нажмите ЛЮБУЮ кнопку");
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");
						do
						{
							int outOfRange = 0;
							key = Console.ReadKey(true).Key;

							switch (key)
							{
								case ConsoleKey.UpArrow:
								case ConsoleKey.W: y--; break;
								case ConsoleKey.DownArrow:
								case ConsoleKey.S: y++; break;
								case ConsoleKey.LeftArrow:
								case ConsoleKey.A: x--; break;
								case ConsoleKey.RightArrow:
								case ConsoleKey.D: x++; break;
								case ConsoleKey.R:
									x_fud = rand.Next(Console.WindowWidth - 1);
									y_fud = rand.Next(1, Console.WindowHeight - 1);
									break;
								default: Console.Beep(); break;
							}

							if (x < 0) x = Console.BufferWidth - 1;
							if (y < 0) y = Console.BufferHeight - 3;
							if (x > Console.BufferWidth - 1) x = 0;
							if (y > Console.BufferHeight - 3) y = 0;
							if (x == x_fud && y == y_fud) { x_fud = rand.Next(Console.WindowWidth - 1); y_fud = rand.Next(1, Console.WindowHeight - 1); fud++; outOfRange++; }
							if (outOfRange > 0) Console.Beep(300, 170);
							Console.Clear();
							//Console.BackgroundColor = ConsoleColor.Red;
							Console.SetCursorPosition(x, y);
							Console.WriteLine("+");
							//Console.BackgroundColor = ConsoleColor.Black;
							Console.SetCursorPosition(x_fud, y_fud);
							Console.WriteLine("@");
							Console.SetCursorPosition(65, 0);
							//Console.WriteLine($"X = {x}");
							//Console.WriteLine($"Y = {y}");
							Console.WriteLine("W,S,A,D - передвижение       Escape - Закончить Игру");
							Console.SetCursorPosition(1, 0);
							Console.WriteLine($"Яблок скушено {fud}");

							if (fud == 3) key = ConsoleKey.Escape;
						} while (key != ConsoleKey.Escape);
						Console.Clear();
						if (fud == 2)
						{
							Console.BackgroundColor = ConsoleColor.Green;
							Console.ForegroundColor = ConsoleColor.DarkBlue;
							Console.SetCursorPosition(20, 5);
							Console.WriteLine("-------------------------------- УРА --------------------------------");
							Console.ForegroundColor = ConsoleColor.White;
							Console.BackgroundColor = ConsoleColor.Black;
							Console.Beep(250, 750);
							Console.SetCursorPosition(46, 8);
							Console.BackgroundColor = ConsoleColor.Green;
							Console.ForegroundColor = ConsoleColor.DarkBlue;
							Console.WriteLine("!!!Вы Победили!!!");
							Console.Beep(350, 950);
							Console.SetCursorPosition(46, 12);
							Console.WriteLine("!!!Поздравляем!!!");
							Console.ForegroundColor = ConsoleColor.White;
							Console.BackgroundColor = ConsoleColor.Black;
							Console.SetCursorPosition(37, 10);
							Console.Beep(250, 1150);
							Console.WriteLine("Нажмите 'X' Для выхода в главное меню");
						}
						else
						{
							Console.BackgroundColor = ConsoleColor.Red;
							Console.ForegroundColor = ConsoleColor.DarkBlue;
							Console.SetCursorPosition(20, 5);
							Console.WriteLine("-------------------------------- УВЫ --------------------------------");
							Console.Beep(180, 550);
							Console.ForegroundColor = ConsoleColor.White;
							Console.BackgroundColor = ConsoleColor.Black;
							Console.SetCursorPosition(48, 10);
							Console.BackgroundColor = ConsoleColor.Red;
							Console.ForegroundColor = ConsoleColor.DarkBlue;
							Console.WriteLine("Вы Проиграли =(");
							Console.Beep(140, 950);
							Console.ForegroundColor = ConsoleColor.White;
							Console.BackgroundColor = ConsoleColor.Black;
							Console.SetCursorPosition(37, 16);
							Console.WriteLine("Нажмите 'X' Для выхода в главное меню");
							Console.Beep(110, 850);



						}
						key = ConsoleKey.Escape;
						break;
					case ConsoleKey.D3:
						Console.Clear();
						Console.Beep(400, 150);
						Console.SetCursorPosition(2, 0);
						Console.WriteLine($"1)Правила");
						Console.SetCursorPosition(2, 1);
						Console.WriteLine($"2)Начать игру");
						Console.SetCursorPosition(2, 2);
						Console.WriteLine($"3)Управления");
						Console.SetCursorPosition(2, 5);
						Console.WriteLine("4)Завершить игру");
						Console.SetCursorPosition(30, 0);
						Console.WriteLine("W,S,A,D или Стрелочки - передвижение ");
						Console.SetCursorPosition(30, 1);
						Console.WriteLine("Escape - Закончить игру");
						Console.SetCursorPosition(30, 2);
						Console.WriteLine("R - переместить яблоко (Можно использовать если яблоко пропало) ");
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("В случае если клавиша не используется вы услышите БИП");
						Console.SetCursorPosition(30, 3);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");
						break;
					case ConsoleKey.D4:
						Console.Clear();
						Console.Beep(400, 150);
						Console.SetCursorPosition(36, 3);
						Console.WriteLine("Вы уверены что хотите завершить игру?");
						Console.SetCursorPosition(46, 4);
						Console.WriteLine("Да (Z)/ Нет(X)");
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");
						break;
					case ConsoleKey.X:
						Console.Clear();
						Console.Beep(400, 150);
						Console.SetCursorPosition(2, 0);
						Console.WriteLine($"1)Правила");
						Console.SetCursorPosition(2, 1);
						Console.WriteLine($"2)Начать игру");
						Console.SetCursorPosition(2, 2);
						Console.WriteLine($"3)Управления");
						Console.SetCursorPosition(2, 5);
						Console.WriteLine("4)Завершить игру");
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");
						break;

					default: Console.Beep(500, 100); break;
				}
			} while (key != ConsoleKey.Z);








		}
	}
}