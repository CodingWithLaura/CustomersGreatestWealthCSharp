using System;

namespace GreatestWealth
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] testAccounts = {{10, 4, 1}, {7, 1, 3}, {1, 9, 5}};
            Solution solution = new Solution();
            int greatestWealth = solution.CustomersGreatestWealth(testAccounts);
	    Console.WriteLine($"The highest wealth of a customer sums up to {greatestWealth}");
            Console.Read();
        }
    }
}
