//v0.1 copyright ?????? 20150511M0650
using System;
using System.Collections.Generic;

/// So currently, PrimeGenerator.cs can get prime numbers by 
/// Checking checking that every integer below the prime number won't
/// output a whole number if you divide by that number.
/// That is O(n^2).
/// There is an algorithm called the Sieve of Eratosthenes that is
/// supposedly quickly.
/// The algorithm says: 
/// 1. Get a list from one to n, where n is the number you want to check up too.
/// 2. Let p = the first prime number (initially 2).
/// 3. "Mark" numbers that are a multiple of p. (2p, 3p, 4p, ...) 
/// 4. Find the first unmarked number in the list that's greater than p. 
/// 5. Repeat step 3. 

public class SieveGenerator
	{
	//////////////////////////////////////////
	// Start by making a class that has two properties, "number" and "marked."
	public class Number
		{
		public int number; // The number in our list.
		public bool marked; // If the number is "marked" or not.
		}
	
	////////////////////////////////////////////
	// Initialize the list of unmarked numbers.
	public List<Number> UnmarkedList(int n)
		{
		List<Number> InitList = new List<Number>();

		// Our list starts at number 2. Everything is unmarked at first.
		for(int k = 0; k < n - 1 ; k++) // n-1 because if you input 100 the program will output 101 as an answer
			{ InitList.Add(new Number() {number= k+2 , marked = false}); }
		return InitList;
		}

	////////////////////////////////////////////
	// Marks up the list for the current p.
	public List<Number> ListMarkup(List<Number> UnmarkedList , int p)
		{
		// Mark every multiple of p. 
		for (int w = 0; w < UnmarkedList.Count; w++)
			{
				if (UnmarkedList[w].number % p == 0 && UnmarkedList[w].number != p)
				{ UnmarkedList[w].marked = true; } // List gets marked here.
			}
		return UnmarkedList; // This is really the renewed list.
		}

	/////////////////////////////////////////////////
	// Check if there's an unmarked number greater than p.
	// If yes, return what that number is. If no, 0.
	public int Check(List<Number> TheList, int p)
		{ 
		int check = 0;
		// The p is TheList[p-2].number since we start our list at 2.
		for (int w = p-1; w < TheList.Count; w++) // The init w is not unreachable because p always starts at 2.
			{ 
			if (TheList[w].marked == false);
				{ 
				check = TheList[w].number;
				break;
				}	
			}
		return check;
		}

	////////////////////////////////////////////
	// Return the primes from the first n integers
	public List<int> GetPrimes(int n)
		{
		List<Number> InitList = UnmarkedList(n); // Startout with an unmarked list.
		int p = 2; // We always start out with p = 2.

		// Initialize a temporary list that continuously gets marked.
		List<Number> TempList = ListMarkup(InitList, p);

		for(int j = 0; ; j++)
			{ 
			int NewP = Check(TempList, p); // Check if there's an unmarked number greater than p.

			if (NewP == 0)
				{ break; } // If no, break.
			else
				{
				p = NewP; // If yes Set p = to that new number and run ListMarkup.
				TempList = ListMarkup(TempList, p);
				} 
			}

		// At this point in the method, the Temp List should have marked all non-prime numbers.
		// Make a new list with only the prime numbers.
		List<int> PrimeList = new List<int>();
		for (int k = 0; k < TempList.Count; k++)
			{ 
			if (TempList[k].marked == false)
				{ PrimeList.Add(TempList[k].number); }
			}
		return PrimeList;
		}

	//////////////////////////////////////////
	// Print the primes up to number n.
	public void PrintPrimes(int n)
		{
		List<int> ListOfPrimes = GetPrimes(n);
		System.Console.WriteLine("The primes up to number {0} are:", n);
		for (int z = 0; z < ListOfPrimes.Count ; z++)
			{ System.Console.WriteLine(ListOfPrimes[z]); }
		}

	//////////////////////////////////////////
	public SieveGenerator()
		{
			// Nothing Here Yet
		}


	/////////////////////////////////////////
	~SieveGenerator()
		{
			// Nothing Here Yet
		}
	}

