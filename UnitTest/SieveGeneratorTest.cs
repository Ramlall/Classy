using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SieveGeneratorTest
	{
	[TestMethod]
	public void SieveGTest()
		{
		SieveGenerator gen = new SieveGenerator();

		////////////////////////////////////////////////////////////
		// Check that the UnmarkedList is correct.
		int n = 100; // This list should contain the numbers from 2 to 100.
		int[] UnmarkedArray = gen.UnmarkedList(n).Select(UnmarkedList=>UnmarkedList.number).ToArray();
		// Jesus christ looking up that syntax to convert a list of objects to an array was crazy.

		for (int k = 2; k < n; k++)
			{ 
			if (k != UnmarkedArray[k-2])
				{ throw new Exception("UnmarkedList gave a bad list in SieveGenerator.cs"); }
			}

		//////////////////////////////////////////////////////////////
		// Check if GetPrimes works.

		int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
		int[] notprimes = { 0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18 };

		// Generate a list of primes from GetPrimes() in PrimeGenerator.cs.
		// The list will be up to the number of manual entries we have for our unit test.
		List<int> TestList = gen.GetPrimes(primes.Length + notprimes.Length);

		for (int w = 0; w < primes.Length; w++)
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
