using System;
namespace Desktop.NumericRepresentation
{
	class NumericRepresentationConvert
	{
		// Still dont work with decimal numbers.
		// Dont work wiht letters.
		public static double ToDecimal(string number, int b0)
		{
			double result = 0;
			int length = number.Length - 1;
			for (int i=0; i<=length; i++)
			{
				result += (double)Char.GetNumericValue( number[length-i] ) * Math.Pow(b0, i);
			}
			return result;
		}

		public static string FromDecimalToAnyBase(double number, int b0) {
			//double n = number;
			string result = "";
			do {
				result = Convert.ToString(number % b0) + result;
				number = (int)(number / b0);
			} while(number > 0);

			return result;
		}
		public static string FromAnyBaseTo(string number, int bo, int bf) {
			return FromDecimalToAnyBase(
				ToDecimal(number, bo),
				bf
			);
		}
	}
}