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
		List<int> ListOfPrimes = GetPrimes(n);
		for(int z = 0; z < n; z++)
			{
			System.Console.WriteLine(ListOfPrimes[z]);
			}	
		}


	///////////////////////////////////////////
	public List<int> GetPrimes(int n)
		{
		// Return the first n primes
		List<int> PrimeList = new List<int>();

		for (int k = 0; k <= k + 1; k++) // Forever for-loop.
			{
			if (IsPrime(k) == true)
				{ 
				PrimeList.Add(k); 
				if (PrimeList.Count == n)
					{ break; }
				}
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

