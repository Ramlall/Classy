using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PrimeGeneratorTest
	{
	[TestMethod]
	public void TestMethod1()
		{
		PrimeGenerator gen=new PrimeGenerator();
		
		// Check if primes works
		int[] primes={2,3,5,7,11,13,17,19};
		
		for(int i=0;i<primes.Length;++i)
			{
			if(gen.IsPrime(primes[i])==false)
				{
				throw new Exception("Number should be a prime");
				}
			}

		// check if nonprimes work		
		int[] notprimes={0,1,4,6,8,9,10,12,14,15,16,18};
		for(int i=0;i<primes.Length;++i)
			{
			if(gen.IsPrime(notprimes[i])==true)
				{
				throw new Exception("Number should not be a prime");
				}
			}
		}
	}
