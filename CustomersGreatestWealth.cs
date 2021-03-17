using GreatestWealth;
using NUnit.Framework;

namespace GreatestWealthTest
{
    public class Tests
    {
        [Test]
        public void Given_a_2D_array_of_numbers_the_highest_number_should_be_returned_back()
        {
            //Arrange
            int[,] testArray = {{20, 2, 5, 7}, {5, 1, 9, 3}, {5, 7, 5, 1}, {4, 9, 7,1}};
            int expectedValue = 34;
            Solution solution = new Solution();

            //Act
            int result = solution.CustomersGreatestWealth(testArray);
            
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}