namespace BetaTest_1._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
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
			int y_fud = rand.Next(Console.WindowHeight - 1);
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
								default: Console.Beep(); break;
							}

							if (x < 0) x = Console.BufferWidth - 1;
							if (y < 0) y = Console.BufferHeight - 3;
							if (x > Console.BufferWidth - 1) x = 0;
							if (y > Console.BufferHeight - 3) y = 0;
							if (x == x_fud && y == y_fud) { x_fud = rand.Next(Console.WindowWidth - 1); y_fud = rand.Next(Console.WindowHeight - 1); fud++; outOfRange++; }
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

							if (fud == 2) key = ConsoleKey.Escape;
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
							Console.Beep(250, 1250);
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
							Console.Beep(110, 750);
							Console.WriteLine("Нажмите 'X' Для выхода в главное меню");



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
						Console.WriteLine("В случае если клавиша не используется вы услышите БИП");
						Console.SetCursorPosition(48, 28);
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

					default: Console.Beep(800, 200); break;
				}
			} while (key != ConsoleKey.Z);
		}
	}
}