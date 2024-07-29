﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
                return 0;

            return numbers.Min() + numbers.Max();
        }


        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }
        public int SumEvens(int[] numbers)
        {
            // Check if the input array is null and return 0 if true
            if (numbers == null)
            {
                return 0;
            }

            // Calculate the sum of even numbers if the array is not null
            return numbers.Where(n => n % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            // Check if the input list is null and return false if true
            if (numbers == null)
            {
                return false;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum % 2 != 0;  // Returns true if the sum is odd
        }


        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
