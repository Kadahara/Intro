﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint
{
	class Point
	{
		//double x;
		//double y;

		//public double X
		//{
		//	get { return x; }
		//	set
		//	{
		//		if (value > 100) value = 100;
		//		x = value;
		//	}
		//}
		//public double Y
		//{
		//	get { return y; }
		//	set
		//	{
		//		if (value > 80) value = 80;
		//		y = value;
		//	}
		//}
		public double X { get; private set; } = 22;
		public double Y { get; private set; } = 33;
		public Point(double x = 0, double y = 0)
		{
			X = x;
			Y = y;
		}
		public void print()
		{
			Console.WriteLine("X = " + X + "\tY = " + Y);
		}
		public override string ToString()
		{
			return "X = " + X + "\tY = " + Y;
		}
			
	}
}
