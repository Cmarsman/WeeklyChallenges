using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n == 0)
            {
                throw new ArgumentException("n must be greater than 0");
            }

            if (startNumber % n == 0)
            {
                return startNumber;
            }

            return ((startNumber / n) + 1) * n;
        }

        public class Business
        {
            public string Name { get; set; }
            public decimal Revenue { get; set; } 
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses) if (business.Revenue == 0) business.Name = "CLOSED";
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            return numbers
        .Skip(1) 
        .Where((num, index) => numbers[index] % 2 == 0) 
        .Sum(); 
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            return string.Join(" ", words).Trim();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            return elements
        .Where((_, index) => (index + 1) % 4 == 0)
        .ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var seenNumbers = new HashSet<int>();

            foreach (var num in nums)
            {
                if (seenNumbers.Contains(targetNumber - num))
                {
                    return true;
                }
                seenNumbers.Add(num);
            }

            return false;
        }
    }
}
