using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c == 'a' || c == 'A') ;
            return true;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0) ;
            return vals.Length % 2 == 0;
        }
        

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) ;
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
            return numbers?.Sum() ?? 0;
        }

        public int SumEvens(int[] numbers)
        {
            return numbers?.Where(n => n % 2 == 0).Sum() ?? 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
           if (numbers == null || numbers.Count == 0)
               return false;
           
           int sum = numbers.Sum();
           return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
           if (number <= 1) 
               return 0;
           
           return number / 2;
        }
    }
}
