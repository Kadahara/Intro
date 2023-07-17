namespace BetaTest_1._1
{
	internal class Program
	{
		static void menu()
		{
			Console.Clear();
			Console.Beep(320, 110);
			Console.SetCursorPosition(2, 0);
			Console.WriteLine($"1)Правила");
			Console.SetCursorPosition(2, 1);
			Console.WriteLine($"2)Начать игру");
			Console.SetCursorPosition(2, 2);
			Console.WriteLine($"3)Управления");
			Console.SetCursorPosition(2, 3);
			Console.WriteLine("4)Настройки");
			Console.SetCursorPosition(2, 5);
			Console.WriteLine("5)Завершить игру");
		}
		static void Main(string[] args)
		{
			/*
			Console.Title = ("Играй в Змейку (1.2 Beta)");

			Console.BufferHeight = Console.WindowHeight + 1;
			Console.BufferWidth = Console.WindowWidth + 1;
			//Console.WriteLine($"Windows: {Console.WindowWidth} {Console.WindowHeight}");
			//Console.WriteLine($"Buffer: {Console.BufferWidth} {Console.BufferHeight}");
			menu();

			Console.SetCursorPosition(48, 28);
			Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");

			#region GAME
			// Запрет двигаться на 180 градусов
			int rotation = 0;
			bool error = false;

			//Положения яблока
			Random rand = new Random();
			int x_fud = rand.Next(Console.WindowWidth - 1);
			int y_fud = rand.Next(1, Console.WindowHeight - 1);
			// Кол во яблок
			int fud = 0;
			int win = 10;
			// Консоль с показателями
			bool admin = false;

			int sneki_1 = 2;
			int sneki_2 = 0;
			// Положение змейки
			int x = 60;
			int y = 15;
			//Console.CursorVisible = true;
			ConsoleKey key;
			#endregion GAME
			do
			{

				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.D1:
						menu();
						Console.SetCursorPosition(30, 0);
						Console.WriteLine($"1 - Для победы сьешьте {win} яблок. - Можно поменять в меню 'Настройки'. ");
						Console.SetCursorPosition(30, 1);
						Console.WriteLine($"2 - Змейка не может двигаться на 180 градусов!. ");
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");
						break;
					case ConsoleKey.D2:
						Console.Clear();
						Console.Beep(400, 150);
						Console.WriteLine("Для старта нажмите ЛЮБУЮ кнопку");
						Console.Clear();
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");

						#region GAME
						do
						{
							int outOfRange = 0;
							key = Console.ReadKey(true).Key;

							switch (key)
							{
								case ConsoleKey.UpArrow:
								case ConsoleKey.W:
									if (rotation == 2) { error = true; break; }
									y--;
									rotation = 1;
									error = false;
									break;
								case ConsoleKey.DownArrow:
								case ConsoleKey.S:
									if (rotation == 1) { error = true; break; }
									y++;
									rotation = 2;
									error = false;
									break;
								case ConsoleKey.LeftArrow:
								case ConsoleKey.A:
									if (rotation == 4) { error = true; break; }
									x--;
									rotation = 3;
									error = false;
									break;
								case ConsoleKey.RightArrow:
								case ConsoleKey.D:
									if (rotation == 3) { error = true; break; }
									x++;
									rotation = 4;
									error = false;
									break;
								case ConsoleKey.R:
									x_fud = rand.Next(Console.WindowWidth - 1);
									y_fud = rand.Next(1, Console.WindowHeight - 1);
									Console.Clear();
									break;
								case ConsoleKey.U:
									admin = true; break;
								default: Console.Beep(); break;
							}

							if (x < 0) x = Console.BufferWidth - 1;
							if (y < 0) y = Console.BufferHeight - 3;
							if (x > Console.BufferWidth - 1) x = 0;
							if (y > Console.BufferHeight - 3) y = 0;
							if (x == x_fud && y == y_fud)
							{
								x_fud = rand.Next(Console.WindowWidth - 1); y_fud = rand.Next(1, Console.WindowHeight - 1); // перемещения яблока
								fud++;// счетчик очков
								outOfRange++; //сигнал при начислении очков
								sneki_1++; // размер змейки
							}
							if (outOfRange > 0) Console.Beep(300, 170);

							if (sneki_1 == sneki_2 && error != true) { Console.Clear(); sneki_2 = sneki_2 - sneki_1; }
							if (error != true) sneki_2++;
							//Console.BackgroundColor = ConsoleColor.Red;
							Console.SetCursorPosition(x, y);
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("+");
							Console.ForegroundColor = ConsoleColor.White;
							//Console.BackgroundColor = ConsoleColor.Black;
							Console.SetCursorPosition(x_fud, y_fud);
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("@");
							Console.ForegroundColor = ConsoleColor.White;
							Console.SetCursorPosition(65, 0);
							//Console.WriteLine($"X = {x}");
							//Console.WriteLine($"Y = {y}");
							Console.WriteLine("W,S,A,D - передвижение       Escape - Закончить Игру");
							Console.SetCursorPosition(1, 0);
							Console.WriteLine($"Яблок скушено: {fud}");
							if (admin == true)
							{
								Console.WriteLine($"snike: {sneki_1} : {sneki_2}");
								Console.WriteLine($"rotation: {rotation} ");
								Console.WriteLine($"error {error}");
								Console.WriteLine($"win {win}");
								Console.WriteLine($"X {x} : y {y}");
								Console.WriteLine($"fud x = {x_fud} : fud y = {y_fud}");
							}
							if (error == true) { Console.Beep(); Console.SetCursorPosition(20, 0); Console.WriteLine("Нельзя двигаться в обратном направлении!"); }

							if (fud == win) key = ConsoleKey.Escape;
						} while (key != ConsoleKey.Escape);
						#endregion GAME
						Console.Clear();
						if (fud == win)
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
							// профилактика ошибок
							rotation = 0;
							error = false;
							fud = 0;
							sneki_1 = 2;
							sneki_2 = 0;
							admin = false;
							x = 60;
							y = 15;
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
							key = ConsoleKey.Escape;
							// профилактика ошибок
							rotation = 0;
							error = false;
							fud = 0;
							sneki_1 = 2;
							sneki_2 = 0;
							admin = false;
							x = 60;
							y = 15;
						}
						break;
					case ConsoleKey.D3:
						menu();
						Console.SetCursorPosition(30, 0);
						Console.WriteLine("W,S,A,D или Стрелочки - передвижение ");
						Console.SetCursorPosition(30, 1);
						Console.WriteLine("Escape - Закончить игру");
						Console.SetCursorPosition(30, 2);
						Console.WriteLine("R - переместить яблоко (Можно использовать если яблоко пропало) ");
						Console.SetCursorPosition(30, 3);
						Console.WriteLine("В случае если клавиша не используется вы услышите БИП");
						Console.SetCursorPosition(30, 5);
						Console.WriteLine("U - показатель с параметрами");
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");
						break;
					case ConsoleKey.D4:
						Console.Clear();
						Console.Beep(400, 150);
						Console.SetCursorPosition(2, 0);
						Console.WriteLine("1)Изменить кол во яблок для победы");
						Console.SetCursorPosition(2, 1);
						Console.WriteLine("2)Вернуться в меню");
						do
						{
							key = Console.ReadKey(true).Key;
							switch (key)
							{
								case ConsoleKey.D1:
									Console.Clear();
									Console.SetCursorPosition(2, 3);
									Console.WriteLine("Введите кол во яблок для победы, далее нажмите Enter для подтверждения: ");
									Console.SetCursorPosition(74, 3);
									win = Convert.ToInt32(Console.ReadLine());
									Console.SetCursorPosition(2, 0);
									Console.WriteLine("1)Изменить кол во яблок для победы");
									Console.SetCursorPosition(2, 1);
									Console.WriteLine("2)Вернуться в меню");
									break;
								case ConsoleKey.D2:
									menu();
									key = ConsoleKey.X;
									break;
							}
						} while (key != ConsoleKey.X);
						break;
					case ConsoleKey.D5:
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
						menu();
						Console.SetCursorPosition(48, 28);
						Console.WriteLine("Игра находится на стадии Бета-Теста, конечный продукт может отличаться");
						break;
					case ConsoleKey.U:
						admin = true;
						Console.SetCursorPosition(68, 0);
						Console.WriteLine("Режим разработчика включен ('I' - вывести параметры)"); break;
					case ConsoleKey.I:
						if (admin == true)
						{
							admin = false;
							Console.SetCursorPosition(1, 12);
							Console.WriteLine($"snike: {sneki_1} : {sneki_2}");
							Console.WriteLine($"rotation: {rotation} ");
							Console.WriteLine($"error {error}");
							Console.WriteLine($"win {win}");
							Console.WriteLine($"X {x} : y {y}");
							Console.WriteLine($"fud x = {x_fud} : fud y = {y_fud}");
							Console.WriteLine($"admin {admin}");
							break;
						}
						else
						{
							Console.Clear();
							menu();
							break;
						}
					default: Console.Beep(500, 100); break;
				}
			} while (key != ConsoleKey.Z);
			Console.Clear();
			Console.SetCursorPosition(39, 3);
			Console.WriteLine("Спасибо за участие в Бета-Тесте 1.3");
			Console.SetCursorPosition(0, 6);
			Console.WriteLine("Вы можете оставить тут свой отзыв: ");
			Console.SetCursorPosition(44, 27);
			Console.WriteLine("Правда 'Отзывы' сейчас тоже в Бета Тесте, так что их не кто не прочитает ^_^");
			Console.SetCursorPosition(35, 6);
			string reviews = Console.ReadLine();
			*/
			// Запрет двигаться на 180 градусов







			int rotation = 0;
			bool error = false;



			//Положения яблока
			Random rand = new Random();
			int x_fud = rand.Next(Console.WindowWidth - 1);
			int y_fud = rand.Next(1, Console.WindowHeight - 1);
			// Кол во яблок
			int fud = 0;
			int win = 10;
			// Консоль с показателями
			bool admin = false;

			int sneki_1 = 2;
			int sneki_2 = 0;
			// Положение змейки
			int x = 60;
			int y = 15;
			//Console.CursorVisible = true;
			ConsoleKey key;
			do
			{
				int outOfRange = 0;
				key = Console.ReadKey(true).Key;

				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:
						if (rotation == 2) { error = true; break; }
						y--;
						rotation = 1;
						error = false;
						break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S:
						if (rotation == 1) { error = true; break; }
						y++;
						rotation = 2;
						error = false;
						break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:
						if (rotation == 4) { error = true; break; }
						x--;
						rotation = 3;
						error = false;
						break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:
						if (rotation == 3) { error = true; break; }
						x++;
						rotation = 4;
						error = false;
						break;
					case ConsoleKey.R:
						x_fud = rand.Next(Console.WindowWidth - 1);
						y_fud = rand.Next(1, Console.WindowHeight - 1);
						Console.Clear();
						break;
					case ConsoleKey.U:
						admin = true; break;
					default: Console.Beep(); break;
				}

				if (x < 0) x = Console.BufferWidth - 1;
				if (y < 0) y = Console.BufferHeight - 3;
				if (x > Console.BufferWidth - 1) x = 0;
				if (y > Console.BufferHeight - 3) y = 0;
				if (x == x_fud && y == y_fud)
				{
					x_fud = rand.Next(Console.WindowWidth - 1); y_fud = rand.Next(1, Console.WindowHeight - 1); // перемещения яблока
					fud++;// счетчик очков
					outOfRange++; //сигнал при начислении очков
					sneki_1++; // размер змейки
				}
				if (outOfRange > 0) Console.Beep(300, 170);

				if (sneki_1 == sneki_2 && error != true) { Console.Clear(); sneki_2 = sneki_2 - sneki_1; }
				if (error != true) sneki_2++;
				//Console.BackgroundColor = ConsoleColor.Red;
				Console.SetCursorPosition(x, y);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("+");
				Console.ForegroundColor = ConsoleColor.White;
				//Console.BackgroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(x_fud, y_fud);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("@");
				Console.ForegroundColor = ConsoleColor.White;
				Console.SetCursorPosition(65, 0);
				//Console.WriteLine($"X = {x}");
				//Console.WriteLine($"Y = {y}");
				Console.WriteLine("W,S,A,D - передвижение       Escape - Закончить Игру");
				Console.SetCursorPosition(1, 0);
				Console.WriteLine($"Яблок скушено: {fud}");
				if (admin == true)
				{
					Console.WriteLine($"snike: {sneki_1} : {sneki_2}");
					Console.WriteLine($"rotation: {rotation} ");
					Console.WriteLine($"error {error}");
					Console.WriteLine($"win {win}");
					Console.WriteLine($"X {x} : y {y}");
					Console.WriteLine($"fud x = {x_fud} : fud y = {y_fud}");
				}
				if (error == true) { Console.Beep(); Console.SetCursorPosition(20, 0); Console.WriteLine("Нельзя двигаться в обратном направлении!"); }

				if (fud == win) key = ConsoleKey.Escape;
			} while (key != ConsoleKey.Escape);

		}

	}
	
}