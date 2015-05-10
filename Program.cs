
class Program
	{
	static void	Main(string[] args)
		{
		// think of gen as a pointer.  By default gen is null.
		// (People call java/c# object variables as references)
		PrimeGen gen=null;
		gen=new PrimeGen();		// Now gen points to a real instance PrimeGen on heap

		gen.PrintPrimes(10);	// Print out the first 10 primes

		// The object that gen points will be eventually destroyed
		// by the garbage collector automatically sometime in the future
		}
    }
