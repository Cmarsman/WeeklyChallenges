using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (ignoreCase)
            {
                return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return words.Contains(word);
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

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            return elements.Where((e, i) => (i + 1) % n == 0).ToArray();
        }
    }
}
