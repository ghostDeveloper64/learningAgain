using System;
using Desktop.NumericRepresentation;

namespace Desktop
{
    class Program
    {
		static void Main(string[] args) {
			string result = NumericRepresentationConvert
				.FromAnyBaseTo(
					"77", 8, 2
				);
			Console.WriteLine( result );
		}
    }
}