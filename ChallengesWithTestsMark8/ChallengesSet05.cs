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

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(string[] names, double[] revenues)
        {
            Business[] businesses = new Business[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                businesses[i] = new Business()
                {
                    Name = names[i],
                    Revenue = (decimal)revenues[i]
                };
            }

            foreach (var business in businesses)
            {
                if (business.Revenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }




            //if (business.Revenue == 0) business.Name = "CLOSED";
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
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
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
