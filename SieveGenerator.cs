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

		for(int k = 0; k < n; k++)
			{
			InitList[k].number = (k + 2); // Our list starts at number 2.
			// @@@@@@@@@@@@@@@@@@@@@@ THE LINE ABOVE FAILS@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
			// Supposedly you're supposed to Add to a list and not just set the index equal to something.
			// But I'm having trouble getting the syntax to access it.
			// InitList is a list of Class Number with two properties: a bool and an int.
			// How do you add a number to just the int property?
			// InitList.number.Add(k+2); doesn't work.
			// @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
			InitList[k].marked = false; // Everything is unmarked at first.
			}
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
		// The p is indexed as TheList[p-2].number
		for (int w = TheList[p-1].number; w < TheList.Count; w++) // The init w is not unreachable because p always starts at 2.
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
	// Print out the first n primes
	public void PrintPrimes(int n)
		{
		List<int> ListOfPrimes = GetPrimes(n);
		for (int z = 0; z < n; z++)
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

