using System;
using Xunit;

namespace Palindromes.Test
{
    public class UnitTest1
    {
        [Fact]
        public void check_to_see_if_this_string_is_the_same_backwards_as_it_is_forwards()
        {
            //ARRANGE
            var stringToCheck = "Was it a cat I saw?";
            var checker = new Palindrome();

            //ACT
            var result = checker.checkIfPalindrome(stringToCheck);

            //ASSERT
            Assert.Equal("This is a palindrome", result);
        }
    }
}
