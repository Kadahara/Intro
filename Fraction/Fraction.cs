using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Fraction
	{
		int integer;
		int numerator;
		int denominator;
		public int Integer { get; set; }
		public int Numerator { get; set; }
		public int Denominator
		{
			get { return denominator; }
			set
			{
				if (value == 0) value = 1;
				denominator = value;
			}
		}
		public Fraction()
		{
			Denominator = 1;
		}
		public Fraction(int integer)
		{
			Integer = integer;
		}
		public Fraction(int numerator, int denominator)
		{
			Numerator = numerator;
			Denominator = denominator;
		}
		public Fraction(int integer, int numerator, int denominator)
		{
			Integer = integer;
			Numerator = numerator;
			Denominator = denominator;
		}
		public void Print()
		{
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				if (Integer != 0) Console.Write("(");
				Console.Write(Numerator + "/" + Denominator);
				if (Integer != 0) Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}
		public override string ToString()
		{
			return $"{(Integer != 0 ? Integer.ToString() : "")}{(Integer!=0?"(":"")}{(Numerator!=0?$"{Numerator}/{Denominator}":"")}{(Integer != 0 ? ")" : "")} {(Integer == 0 ? Integer.ToString() : "") }";	
		}
	}
}
