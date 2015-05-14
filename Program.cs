
class Program
	{
	static void	Main(string[] args)
		{
		// Ask user how many primes they want.
		System.Console.WriteLine("Please input the number you want to check up too. (Must be above 3.)");
		int prime = System.Convert.ToInt32(System.Console.ReadLine());

		//PrimeGenerator gen = new PrimeGenerator();
		//gen.PrintPrimes(prime);	

		SieveGenerator sieve = new SieveGenerator();
		sieve.PrintPrimes(prime); // Prime MUST be greater than 3 for this to work.
		}
    }
