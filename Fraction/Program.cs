namespace Fraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Fraction A = new Fraction();
			A.Print();
			Console.WriteLine(A);
			Console.WriteLine("________________________");

			Fraction B = new Fraction(5);
			B.Print();
			Console.WriteLine(B);
			Console.WriteLine("________________________");

			Fraction C = new Fraction(1, 2);
			C.Print();
			Console.WriteLine(C);
			Console.WriteLine("________________________");

			Fraction D = new Fraction(2, 3, 6);
			D.Print();
			Console.WriteLine(D);
		}
	}
}