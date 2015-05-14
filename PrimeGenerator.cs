//v0.1 copyright ?????? 20150511M0650
using System.Collections.Generic;

/////////////////////////////////////////////
public class PrimeGenerator
	{

	//////////////////////////////////////////
	// Check if number n is prime
	public bool IsPrime(int n)
		{
		if(n<2) { return false; }

		for(int k=2;k<n;++k)
			{
			if(n % k == 0) { return false; }
			}

		return true;
		}

	
	//////////////////////////////////////////
	// Print out the first n primes
	public void PrintPrimes(int n)
		{
		int primecount=0;
		for(int i=0;i>0;++i)
			{
			if(IsPrime(i)==false) { continue; }

			primecount = primecount + 1;
			System.Console.Write(" {0} ",i);

			if(primecount>=n) { break; }
			}

		System.Console.WriteLine();
		}


	///////////////////////////////////////////
	public List<int> GetPrimes(int n)
		{
		// Return the first n primes
		List<int> PrimeList = new List<int>();

		for (int k = 0; k <= n; k++)
			{
			if (IsPrime(k) == true)
				{ PrimeList.Add(k); }
			}
		return PrimeList;
		}

	//////////////////////////////////////////
	public PrimeGenerator()
		{
		// Nothing Here Yet
		}

	/////////////////////////////////////////
	~PrimeGenerator()
		{
		// Nothing Here Yet
		}
	}

