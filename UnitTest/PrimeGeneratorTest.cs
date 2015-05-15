using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PrimeGeneratorTest
	{
	[TestMethod]
	public void PrimeGTest()
		{
		PrimeGenerator gen=new PrimeGenerator();
		
		////////////////////////////////////////////////////////////

		// Check if primes works
		int[] primes={2,3,5,7,11,13,17,19};
		
		for(int i=0;i<primes.Length;++i)
			{
			if(gen.IsPrime(primes[i])==false)
				{
				throw new Exception("Number should be a prime. IsPrime in PrimeGenerator.cs failed.");
				}
			}
		
		//////////////////////////////////////////////////////////

		// check if nonprimes work		
		int[] notprimes={0,1,4,6,8,9,10,12,14,15,16,18};
		for(int i=0;i<primes.Length;++i)
			{
			if(gen.IsPrime(notprimes[i])==true)
				{
				throw new Exception("Number should not be a prime. IsPrime in PrimeGenerator.cs failed.");
				}
			}

		//////////////////////////////////////////////////////////////

		// Check if GetPrimes works.

		// Generate a list of primes from GetPrimes() in PrimeGenerator.cs.
		// The list will be up to the number of manual entries we have for our unit test.
		List<int> TestList = gen.GetPrimes(primes.Length + notprimes.Length); 

		for(int w = 0; w < primes.Length; w++)
			{
			// Check our manually entered prime list compared to our generated list.
			if (primes[w] != TestList[w])
				{
				throw new Exception("GetPrimes in PrimeGenerator.cs includes a nonprime number in the list.");
				}	
			}

		////////////////////////////////////////////////////////////

		}
	}
