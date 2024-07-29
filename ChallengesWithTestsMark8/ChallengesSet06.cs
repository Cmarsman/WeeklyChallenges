using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            // Handle null input for 'words' safely
            if (words == null)
            {
                return false;
            }

            // If the search word is null, immediately return false
            if (word == null)
            {
                return false;
            }

            // Depending on the ignoreCase flag, perform the appropriate comparison
            if (ignoreCase)
            {
                return words.Any(w => w?.Equals(word, StringComparison.OrdinalIgnoreCase) == true);
            }
            else
            {
                return words.Any(w => w == word);
            }
        }


        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num <= 3) return true;
            if (num % 2 == 0 || num % 3 == 0) return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0) return false;
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var counts = str.GroupBy(c => c).Where(g => g.Count() == 1).Select(g => g.Key).ToHashSet();
            return str.Select((c, i) => new { c, i })
                      .Reverse()
                      .FirstOrDefault(x => counts.Contains(x.c))?.i ?? -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int maxCount = 1, currentCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount, currentCount);
        }

        public double[] GetEveryNthElement(List<double> numbers, int n)
        {
            // Return an empty array if the input list is null or 'n' is less than 1
            if (numbers == null || n < 1)
            {
                return new double[0];
            }

            // Retrieve every nth element starting from the nth-1 index (zero-based)
            return numbers.Where((x, index) => (index + 1) % n == 0).ToArray();
        }

    }
}
