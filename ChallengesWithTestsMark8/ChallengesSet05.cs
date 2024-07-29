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

            // Calculate the next number divisible by n, even if startNumber is already divisible
            return startNumber + (n - startNumber % n);
        }



        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(string[] names, double[] revenues)
        {
            if (names == null || revenues == null || names.Length != revenues.Length)
            {
                throw new ArgumentException("Names and revenues must be non-null and have the same length.");
            }

            for (int i = 0; i < revenues.Length; i++)
            {
                if (revenues[i] == 0)
                {
                    names[i] = "CLOSED";
                }
            }
        }


        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

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
            if (numbers == null)
            {
                return 0;
            }

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
            if (words == null || words.Length == 0)
            {
                return "";
            }

            var filteredWords = words.Where(w => !string.IsNullOrWhiteSpace(w)).Select(w => w.Trim());
            var sentence = string.Join(" ", filteredWords).Trim();
            return sentence.Length > 0 ? sentence + "." : "";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[0];
            }
            return elements
                .Where((_, index) => (index + 1) % 4 == 0)
                .ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null)
            {
                return false;
            }

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
