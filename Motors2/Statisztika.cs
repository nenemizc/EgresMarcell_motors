using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Motors2
{
	internal class Statisztika
	{
		List<Motor> motors = [];

		public void ReadFromFile(string fileName)
		{
			StreamReader sr = new StreamReader(fileName);
			sr.ReadLine();

			while (!sr.EndOfStream) 
			{
				string sor =sr.ReadLine() ?? "";

				string[] szavak = sor.Split(';');

				
				Motor ujMotor = new(szavak[0], szavak[1], Convert.ToInt16(szavak[2]), Convert.ToDouble(szavak[3]), Convert.ToDouble(szavak[4]));

				motors.Add(ujMotor);
			}
		}

		public int SumPrices()
		{
			double sum = 0;
			for (int i = 0; i < motors.Count; i++)
			{
				sum += motors[i].PriceInEur;
			}
			return Convert.ToInt32(sum);
		}

		public bool Contains(string motorName)
		{
			bool asd = false;

			for (int i = 0;i < motors.Count;i++)
			{
				if (motors[i].Name ==motorName) asd = true;
			}
			return asd;
		}

		public Motor Oldest()
		{
			Motor oldest = motors[0];

			for (int i = 0; i < motors.Count; i++)
			{
				if (oldest.ReleaseYear > motors[i].ReleaseYear) oldest = motors[i];
			}

			return oldest;
		}

		public int SumBasedONBrand(string brandName, string fileName)
		{
			List<Motor> brandMotors = new List<Motor>();

			for (int i = 0; i < motors.Count; i++)
			{
				if (motors[i].Brand == brandName) brandMotors.Add(motors[i]);
			}

			int sum = this.SumPrices();

			motors.Clear();
			this.ReadFromFile(fileName);

			return sum;
		}

		public void Sort()
		{
			motors = motors.OrderByDescending(m => m.Performance).ToList();
		}
	}
}
