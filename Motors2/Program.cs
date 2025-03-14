namespace Motors2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Statisztika stat = new();
			stat.ReadFromFile("motors.txt");

            Console.WriteLine("Sum prices:");
			Console.WriteLine(stat.SumPrices());
            Console.WriteLine("\ncontains 'Béla':");
            Console.WriteLine(stat.Contains("Béla"));
            Console.WriteLine("\nOldest:");
            Console.WriteLine(stat.Oldest());
            Console.WriteLine("\nSumBasedOnBrand");
            Console.WriteLine(stat.SumBasedONBrand("Kawasaki", "motors.txt"));

        }
	}
}
