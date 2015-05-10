// Only to be modifed by Tariq

/////////////////////////////////////////////
public partial class PrimeGen
	{
	public bool IsPrime(int n)
		{
		// Fill in the code to check if the number n is prime
        /// A number n is prime if:
        /// 1. n is greater than 1.
        /// 2. n can only be divided by 1 or itself (to form a whole number).
        
		if (n>1)
			{
			for(int k = 2; k <= n; k++) // Scroll through numbers between 1 and n.
				{
				if (n == k) // If we reach the end of the loop, the number satisfies the prime condition.
					return true;
				if (n%k == 0) // If you divide n by some smaller number and the result is a whole number, prime test fails.
					{
					break;
					}
				}
			}
		return false;

		}
	}