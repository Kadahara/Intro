namespace ClassPoint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point point = new Point(5, 0);
			//point.X = 2000;
			//point.Y = 3000;
			Console.WriteLine("X = " + point.X + "\tY = " + point.Y);
			point.print();
			Console.WriteLine(point);
			Console.WriteLine(((Object)2).ToString);
		}
	}
}