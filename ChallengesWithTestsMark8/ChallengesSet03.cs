using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Any(val => val == false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            // Check if the input is null and return false if true
            if (numbers == null)
            {
                return false;
            }

            // Calculate the sum of odd numbers and determine if it is odd
            return numbers.Where(n => n % 2 != 0).Sum() % 2 != 0;
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = password.Any(char.IsUpper);
            bool containsLower = password.Any(char.IsLower);
            bool containsNumber = password.Any(char.IsDigit);

            return containsUpper && containsLower && containsNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            // Check if the divisor is zero and return 0 if true
            if (divisor == 0)
            {
                return 0;
            }

            // Perform the division if the divisor is not zero
            return dividend / divisor;
        }


        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 99).Where(x => x % 2 != 0).ToArray();
        }
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
