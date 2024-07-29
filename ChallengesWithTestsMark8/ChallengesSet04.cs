using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(n => n % 2 == 0).Sum() - numbers.Where(n => n % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new[] { str1.Length, str2.Length, str3.Length, str4.Length }.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
               sideLength1 + sideLength3 > sideLength2 &&
               sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return false;
            }

            int nullCount = objs.Count(x => x == null);

            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            // Check if the input array is null and return 0 if true
            if (numbers == null)
            {
                return 0;
            }

            // Filter out even numbers and calculate their average
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            if (evenNumbers.Count == 0)
            {
                return 0;  // Return 0 if there are no even numbers
            }

            return evenNumbers.Average();  // Return the average of the even numbers
        }


        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be non-negative");
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}
