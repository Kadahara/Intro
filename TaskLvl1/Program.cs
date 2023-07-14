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

			//Console.CursorVisible = true;



			ConsoleKey key;
			int x = 40;
			int y = 40;
			do
			{
				key = Console.ReadKey(true).Key;
				Console.SetCursorPosition(x, y);
				switch (key)
				{
					case ConsoleKey.W: y--; break;
					case ConsoleKey.S: y++; break;
					case ConsoleKey.A: x--; break;
					case ConsoleKey.D: x++; break;
					default: Console.Beep(); break;

				}

				//Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine(".");
				//Console.BackgroundColor = ConsoleColor.Black; 
			} while (key != ConsoleKey.Escape);




		}
	}
}