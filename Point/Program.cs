using System.Runtime.CompilerServices;

namespace Point
{
	internal class Program
	{
		class Point
		{
			public double x, y;
			public Point(double x, double y)
			{
				this.x = x;
				this.y = y;
			}
			public Point(double x)
			{
				this.x = x;
				this.y = 0;
			}
			public void print()
			{
				Console.WriteLine($"X = {x} \t Y = {y}");
			}
			public double Sum()
			{
				return this.x + this.y;
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
			public static Point operator + (Point left, Point right)
			{
				return new Point(left.x + right.x, left.y + right.y);
			}	
			public static Point operator - (Point left, Point right)
			{
				return new Point(left.x - right.x, left.y - right.y);
			}	
			public static Point operator * (Point left, Point right)
			{
				return new Point(left.x * right.x, left.y * right.y);
			}
			public static Point operator / (Point left, Point right)
			{
				return new Point(left.x / right.x, left.y / right.y);
			}	
			public static Point operator ++ ( Point x)
			{
				return new Point(x.x+1!, x.y+1);
			}
			public static Point operator -- ( Point x)
			{
				return new Point(x.x-1!, x.y-1);
			}
			public static bool operator != ( Point left, Point right)
			{
				left.Sum();
				right.Sum();
				return left != right;
			}
			public static bool operator == ( Point left, Point right)
			{
				left.Sum();
				right.Sum();
				return left == right;
			}
			public static bool operator > ( Point left, Point right)
			{
				left.Sum();
				right.Sum();
				return left > right;
			}
			public static bool operator < ( Point left, Point right)
			{
				left.Sum();
				right.Sum();
				return left < right;
			}
			public static bool operator <= ( Point left, Point right)
			{
				left.Sum();
				right.Sum();
				return left <= right;
			}
			public static bool operator >= ( Point left, Point right)
			{
				left.Sum();
				right.Sum();
				return left >= right;
			}
			//public static Point operator=(Point other)
			//{

			//	return new Point(ref.x = other.x, ref.y = other.y);
			//}

		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Point A = new Point(7, 8);
			A.print();
			Point C = new Point(9, 5);
			C.print();

			Point B = new Point(7);
			B.print();

			B = A - C;
			B.print();

			A--;
			A.print();

			Console.WriteLine($"{A.Sum()}");
			







		}
	}
}