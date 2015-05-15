//v0.1 copyright ?????? 20150515F1054
using System.Collections.Generic;

////////////////////////////////////////////////
public class NumberOps
	{
	/////////////////////////////////
	public NumberOps()
		{
		// Nothing yet
		}

	////////////////////////////////
	~NumberOps()
		{
		// Nothing yet
		}


	/// <summary>
	/// This Function will return the digits of a number in a list
	/// </summary>
	/// <param name="number">the number is positive</param>
	/// <returns>List of digits</returns>
	
	///////////////////////////////////////////////////////
	// Find the number of digits in the number.  
	public int NumberOfDigits(int number)
		{ 
		string myString = number.ToString();
		int DigitCount = myString.Length;

		return DigitCount;
		}


	///////////////////////////////////////////////////////
	// Get an int value for 10 raised to a power.
	public int PowerOfTen(int i)
		{ 
		int power = 1;
		for (int k = 1; k <= i; k++)
			{ 
			power = power * 10;
			}
		return power;
		}


	///////////////////////////////////////////////////////
	// Return a list of the digits. 
	public List<int> GetDigits(int number)
		{
		// Fill code to return a list of digits 
		// For instance  the digit 1234 should return the list 1->2->3->4.
		// Do not work about non positive numbers!

		List<int> Digits = new List<int>(); // List we'll be returning.
		
		int DigitCount = NumberOfDigits(number); // Check how many digits are in the number.

		// Digit = [ number % (10^(the digits place)) ] / (10 ^ (the digits place - 1))
		// The digits place = 1 if it's all the way on the right, 2 if it's in the 10s place, 3 if it's in the hundreds, etc.

		for(int k = 1; k <= DigitCount; k++)
			{
			// Can't use System.Math.Pow for the exponents because the number would have to be a double. 
			int digit = ( number % PowerOfTen(k) ) / PowerOfTen(k-1);
			Digits.Add(digit);
			}

		return Digits;
		}


	//////////////////////////////////////////////////////
	public void PrintDigits(int number)
		{ 
		List<int> Digits = GetDigits(number);
		System.Console.WriteLine("The digits in {0} are:", number);
		for (int k = Digits.Count - 1; k >= 0; k--) // For loop is in reverse order so the digits come out first to last.
			{ System.Console.WriteLine(Digits[k]); }
		}
	}
