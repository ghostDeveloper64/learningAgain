using System;
using Desktop.NumericRepresentation;

namespace Desktop
{
    class Program
    {
		static void Main(string[] args) {
			string result = NumericRepresentationConvert
				.FromAnyBaseTo(
					"105.12", 10, 8
				);
			Console.WriteLine( result );
		}
    }
}