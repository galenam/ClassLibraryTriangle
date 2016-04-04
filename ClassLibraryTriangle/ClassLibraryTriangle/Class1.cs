using System;
using System.Linq;

namespace ClassLibraryTriangle
{
    public static class TriangleSquare
    {
		//public delegate double FuncDefine(double a, double b, double c, out double cathetus1,
		//	out double cathetus2);

		//public static double CalculateSquare(double a, double b, double c, FuncDefine func)
		//{
		//	if (a <= 0 || b <= 0 || c <= 0) return 0;
		//	double cathetus1, cathetus2;
		//	var hypothenuse = func(a, b, c, out cathetus1, out cathetus2);
		//	var squareRectangle = cathetus1 * cathetus1 + cathetus2 * cathetus2;
		//	if (!hypothenuse.Equals(Math.Sqrt(squareRectangle))) return 0;
		//	return 0.5 * squareRectangle;
		//}


		//// на  1000000 запросов время выполнения 0.8 секунды
		//private static double DefineHypothenuseAndCathetusLinq(double a, double b, double c, out double cathetus1,
		//	out double cathetus2)
		//{
		//	cathetus1 = 0;
		//	cathetus2 = 0;
		//	if (a <= 0 || b <= 0 || c <= 0) return 0;
		//	var listOfValues = new[] { a, b, c }.OrderBy(key => key);

		//	cathetus1 = listOfValues.FirstOrDefault();
		//	cathetus2 = listOfValues.Skip(1).FirstOrDefault();
		//	return listOfValues.LastOrDefault();
		//}

		//// на  1000000 запросов время выполнения 0.06 секунды
		//private static double DefineHypothenuseAndCathetusDouble(double a, double b, double c, out double cathetus1,
		//	out double cathetus2)
		//{
		//	cathetus1 = 0;
		//	cathetus2 = 0;
		//	var hypothenuse = Math.Max(a, Math.Max(b, c));
		//	if (a.Equals(hypothenuse)) {
		//		cathetus1 = b;
		//		cathetus2 = c;
		//	} else if (b.Equals(hypothenuse)) {
		//		cathetus1 = a;
		//		cathetus2 = c;
		//	} else {
		//		cathetus1 = a;
		//		cathetus2 = b;
		//	}
		//	return hypothenuse;
		//}

		//public static double CalculateSquareLinq(double a, double b, double c)
		//{
		//	return CalculateSquare(5, 4, 3, DefineHypothenuseAndCathetusLinq);
		//}

		//public static double CalculateSquareDoble(double a, double b, double c)
		//{
		//	return CalculateSquare(5, 4, 3, DefineHypothenuseAndCathetusDouble);
		//}

		// на  1000000 запросов время выполнения 0.03 секунды
		public static double CalculateSquareFast(double a, double b, double c)
		{
			if (a <= 0 || b <= 0 || c <= 0) return 0;
			var hypothenuse = Math.Max(a, Math.Max(b, c));
			double cathetus1 = 0;
			double cathetus2 = 0;
			if (a.Equals(hypothenuse)) {
				cathetus1 = b;
				cathetus2 = c;
			} else if (b.Equals(hypothenuse)) {
				cathetus1 = a;
				cathetus2 = c;
			} else {
				cathetus1 = a;
				cathetus2 = b;
			}
			var squareRectangle = cathetus1 * cathetus1 + cathetus2 * cathetus2;
			if (!hypothenuse.Equals(Math.Sqrt(squareRectangle))) return 0;
			return 0.5 * squareRectangle;
		}
	    
    }
}
