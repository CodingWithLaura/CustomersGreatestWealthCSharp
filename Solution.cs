using System;
using System.Linq;

namespace GreatestWealth
{
    public class Solution
    {
        public int CustomersGreatestWealth(int[,] customeraccounts)
        {
            int[] sumCredits = new int[customeraccounts.Length];
            
            for (int j = 0; j < customeraccounts.GetLength(0); ++j)
            {
		int customerCredits = 0;
                for (int i = 0; i < customeraccounts.GetLength(1); ++i)
                {
                    customerCredits = customerCredits + customeraccounts[j, i];
                }

                sumCredits[j] = customerCredits;
            }
	    
            int greatestWealth = sumCredits.Max();
	    
            return greatestWealth;
        }
    }
}
