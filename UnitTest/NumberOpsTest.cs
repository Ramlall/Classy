using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class NumberOpsTest
	{
	[TestMethod]
	public void NumberOTest()
		{
		NumberOps num = new NumberOps();

		////////////////////////////////////////////////////////////
		// Check if the digits are correct
		int number = 123459876; // Our test number.
		List<int> Digits = num.GetDigits(number); // Get a list of the digits from our method in NumberOps.cs

		int GeneratedNumber = 0; // All of the digits will be added to the number.

		for(int c = 0; c < Digits.Count; c++)
			{
			GeneratedNumber = GeneratedNumber + Digits[c] * num.PowerOfTen(c);
			}

		if (GeneratedNumber != number)
			{ throw new Exception("Digit check failed."); }

		////////////////////////////////////////////////////////////

		}
	}
