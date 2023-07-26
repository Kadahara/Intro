using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region ARRAY
			/*
			//int[] arr = new int[] { 3, 5, 8, 13, 21 };

			Console.Write("Укажите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			//Заполнения массива случайными числами: 
			//1) Создаем обьект класса Random:
			//2) Заполняем массив 
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}
			//2)вывод массива на экран:
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();


			int sum = 0;
			int avg = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			avg = sum / arr.Length;

			Console.WriteLine(sum);
			Console.WriteLine(avg);
			Console.WriteLine($"{arr.Max()}");
			Console.WriteLine($"{arr.Min()}");

			Array.Sort(arr);

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			*/
			#endregion ARRAY

			#region ARRAY_2
			/*
			Console.WriteLine("Введите кол-во строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите кол-во столбцов: ");
			int cols = Convert.ToInt32(Console.ReadLine());
			Random rand = new Random();

			int[,] i_arr_2 = new int[rows, cols];
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
			Console.WriteLine();
			}
			int sum = 0;
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					sum += i_arr_2[i, j];
				}
			}
			Console.WriteLine($"Сумма элементов массива = {sum}");
			Console.WriteLine($"Сумма элементов массива = {i_arr_2.Cast<int>().Sum()}");
			Console.WriteLine($"Сред ареф элементов массива = {i_arr_2.Cast<int>().Average()}");
			*/
			#endregion ARRAY_2

			#region RAGGER_ARRAY

			/*

			//Console.WriteLine("Введите кол-во строк: ");
			//int rows = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine("Введите кол-во столбцов: ");
			//int cols = Convert.ToInt32(Console.ReadLine());

			//создание
			
			int[][] ragger_arr = new int[4][];
			ragger_arr[0] = new int[] { 0, 1, 1, 2 };
			ragger_arr[1] = new int[] { 3, 5, 8};
			ragger_arr[2] = new int[] { 13, 21, 34, 55, 89 };
			ragger_arr[4] = new int[] { 144, 233, 377};
			//for (int i = 0; i < ragger_arr.Length; i++)
			//{
			//	ragger_arr[i] = new int[cols];
			//}
			 //заполнение
			Random rand = new Random(0);
			for (int i = 0; i < ragger_arr.Length; i++)
			{
				for (int j = 0; j < ragger_arr[i].Length; j++)
				{
					ragger_arr[i][j] = rand.Next(100);
				}
			}
			// вывод 
			for (int i = 0; i < ragger_arr.Length; i++)
			{
				for (int j = 0; j < ragger_arr[i].Length; j++)
				{
					Console.Write(ragger_arr[i][j] + "\t");
				}
				Console.WriteLine();
			}
			// вывод 
			foreach (int[] i in ragger_arr)
			{
				if (i != null)
				{
					foreach (int j in i)
					{
						Console.Write(j + "\t");
					}
				}
				else Console.WriteLine("Строка пустая");
				Console.WriteLine();
			}

			*/

			#endregion RAGGER_ARRAY

			/*
			Season season = Season.Spring;
			Console.WriteLine(season);

			System.Enum.GetName(typeof(Week), Week.Friday);
			Console.WriteLine($"{System.Enum.GetName(typeof(Week), Week.Friday)}");
			*/
			//Week day = Week.Sunday;
			//Console.WriteLine(day);
			//Console.WriteLine(Enum.GetUnderlyingType(typeof(Week)));

			string[] days =  Enum.GetNames(typeof(Week));
			int[] day_numbers = (int[])Enum.GetValues(typeof(Week));
			for (int i = 0; i < day_numbers.Length; i++)
			{
				Console.WriteLine($"Name: {days[i]} \t Value: {day_numbers[i]}");
			}
			Console.WriteLine(delimiter);
			string[] distName = Enum.GetNames(typeof(DistanceFromSum));
			ulong[] distValue = (ulong[])Enum.GetValues(typeof(DistanceFromSum));
			for (int i = 0; i < distName.Length; i++)
			{
				Console.WriteLine($"Name: {distName[i]}\t= {distValue[i]}");
			}
			Console.WriteLine($"Type: {Enum.GetUnderlyingType(typeof(DistanceFromSum))}");

		}
		const string delimiter = "\n------------------------------------------------------\n";
		enum Week { Sunday, Monday, Thueday, Wendnesday, Thursday, Friday, Saturday };
		enum DistanceFromSum : ulong 
		{
			Sum = 0,
			Mercury = 57900000,
			Venus = 108200000,
			Earth = 149600000,
			Mars = 227900000,
			Jupiter = 7783000000,
			Saturn = 1427000000,
			Uranus = 2870000000,
			Neptune = 4496000000,
			Pluton = 594600000,
		}

		/*
		enum Season
		{
			Winter, Spring, Summer, Autumn
		}
		enum Week : uint
		{
			Sunday = 0,
			Monday = 1,
			Thueday = 2,
			Wendnesday = 3,
			Thursday = 4,
			Friday = 5,
			Saturday = 6,
		}
		*/
	}
}
