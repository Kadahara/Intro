using System.Net.WebSockets;

namespace Pointers
{
	internal class Program
	{
		struct Point
		{
			public double x, y;
			public Point(double x, double y)
			{
				this.x = x;
				this.y = y;
			}
			public void print()
			{
				Console.WriteLine($"X = {x} \t Y = {y}");
			}
			public double distance(Point other)
			{
				//double x_distance = this.x - other.x;
				//double y_distance = this.y - other.y;
				//double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
				//return distance;
				return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));
				// Класс Math содержит набор статических методов, реализующих математические функции.
			}
			public static double distance(Point left, Point right)
			{
				return left.distance(right);
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Point A;
			A.x = 2;
			A.y = 3;
			A.print();

			Point B = new Point(7, 8);
			B.print();

			Console.WriteLine($"расстояние от отчки 'А' до точки 'B'{A.distance(B)}");
			Console.WriteLine($"расстояние от отчки 'B' до точки 'A'{B.distance(A)}");

			Console.WriteLine($"Расстояние между точками А и B : {Point.distance(A, B)}");

			Console.WriteLine($"Расстояние между точками1: {Point.distance(new Point(22,33), new Point(77,88))}");
			Console.WriteLine($"Расстояние между точками2: {new Point(22,33).distance(new Point(77,88))}");

		}
	}
}