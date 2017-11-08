using System;
namespace Desktop.NumericRepresentation
{
	class NumericRepresentationConvert
	{
		private static int numberOfDecimals = 20;
		// Dont work wiht letters.
		public static double ToDecimal(string number, int b0)
		{
			double result = 0;
			int start = 0;
			int length = number.Length - 1;
			// Fractions.
			int dotIndex = number.IndexOf('.');
			if (dotIndex > -1) {
				// Calculate the power of the last number.
				start = (dotIndex + 1) - number.Length;
			}
			for (int i=0; i<=length; i++)
			{
				// start-- because the dot use one index.
				if (number[length-i].Equals('.')) {start--;continue;}
				result += (double)Char.GetNumericValue( number[length-i] ) * Math.Pow(b0, start + i);
			}
			return result;
		}

		public static string FromDecimalToAnyBase(double number, int b0) {
			string result = "";
			double decimalPart = number - Math.Floor(number);
			number = (int)number;

			// Fractions.
			for (int i=0; i<numberOfDecimals; i++) {
				decimalPart *= b0;

				result += (int)decimalPart;
				decimalPart =  decimalPart - Math.Floor(decimalPart);
			}
			result = "."+result;
			// Number.
			do {
				result = Convert.ToString(number % b0) + result;
				number = (int)(number / b0);
			} while(number != 0);

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