
class Program
	{
	static void	Main(string[] args)
		{
		// Hi Steven.
		///////////// FOR PRIMES ////////////////////
		// Ask user how many primes they want.
		System.Console.WriteLine("Please input the number you want to check up too. (Must be above 3.)");
		int prime = System.Convert.ToInt32(System.Console.ReadLine());

		// For regular for loop Prime Generator.
		//PrimeGenerator gen = new PrimeGenerator();
		//gen.PrintPrimes(prime);	

		// For Sieve Algorithm Generator
		SieveGenerator sieve = new SieveGenerator();
		sieve.PrintPrimes(prime); // Prime MUST be greater than 3 for this to work.

		//////////////////////////////////////////////////////////


		/////////////// FOR DIGITS /////////////////
		System.Console.WriteLine("Please enter a number so we can break it down into it's digits.");
		int digits = System.Convert.ToInt32(System.Console.ReadLine());

		NumberOps num = new NumberOps();
		num.PrintDigits(digits);
		///////////////////////////////////////////////////////
		}
    }
