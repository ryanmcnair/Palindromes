using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;


namespace Palindromes
{
    public class Palindrome
    {
        public string checkIfPalindrome(string stringToReverse)
        {
            string toLowercase = stringToReverse.ToLower();

            string removeSpaces = toLowercase.Replace(" ", string.Empty);

            string inputSansPunc = removeSpaces.Where(c => !char.IsPunctuation(c)).Aggregate("", (current, c) => current + c);

            string output = new string(inputSansPunc.ToCharArray().Reverse().ToArray());
            
            if (inputSansPunc == output)
            {
                return "This is a palindrome";
            } 
            else
            {
                return "This is not a palindrome";
            }

            
        }
    }
}
