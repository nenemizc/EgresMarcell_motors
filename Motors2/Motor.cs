using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors2
{
	internal class Motor
	{
		string brand;
		string name;
		int releaseYear;
		double performance;
		double priceInEur;

		public Motor(string brand, string name, int releaseYear, double performance, double priceInEur)
		{
			this.brand = brand;
			this.name = name;
			this.releaseYear = releaseYear;
			this.performance = performance;
			this.priceInEur = priceInEur;
		}
	}
}
