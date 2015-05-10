// I'm bored waiting for Steven so I'll write a unit test for my class. 
using System;

public class UnitTestTariq
	{
	//Testing if the function to determine whether a number is prime or not works.
	//Let's check a list of numbers we know the answer for and see if we get the expected answer.

	public static void CheckIsPrime()
		{
		// One array array for the numbers, one array for the answers. 
		int[] NumberCheckArray = new int[10];
		bool[] TruthCheckArray = new bool[10];

		// Fill the first array with numbers from 1 to 10.
		for(int n = 1; n <= 10; n++)
			{
			NumberCheckArray[n-1] = n;
			}

		// Seems ghetto but it seems like you should manually enter the values.
		// If I tried to do it with calculations then -this- might be wrong too.
		TruthCheckArray[0] = false; // 1 is not prime.
		TruthCheckArray[1] = true; // 2 is prime.
		TruthCheckArray[2] = true; // 3 is prime.
		TruthCheckArray[3] = false; // 4 is not prime.
		TruthCheckArray[4] = true; // 5 is prime.
		TruthCheckArray[5] = false; // 6 is not prime.
		TruthCheckArray[6] = true; // 7 is prime.
		TruthCheckArray[7] = false; // 8 is not prime.
		TruthCheckArray[8] = false; // 9 is not prime.
		TruthCheckArray[9] = false; // 10 is not prime. 

		// Check IsPrime.
		for (int k = 1; k <= 11; k++)
			{
			if (k == 11)
				{
				Console.WriteLine("IsPrime works.");
				break;
				}
			PrimeGen primegen = new PrimeGen(); // Had to make an instance of this. 
			if (primegen.IsPrime(k) == TruthCheckArray[k-1])
				continue;
			else
				{
				Console.WriteLine("IsPrime failed for number {0}! Go and fix it.", k);
				break;
				}
			}

		}

	}
