using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
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

			





		}
	}
}
