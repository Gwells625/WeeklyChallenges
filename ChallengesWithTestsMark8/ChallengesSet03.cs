using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)//Takes a bool array and returns true if any value is false
        {
            foreach (bool val in vals)//Loop through each element in the array
            {
                if (val == false)//If a false is found, return true 
                {
                    return true;
                }
            }
            
            return false;//If no false was found, return false
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)//Handle null input to avoid exceptions
                return false;
            
            int sumOfOdds = 0;//Calculate the sum of only odd numbers
            foreach (int number in numbers)
            {
                if (number % 2 != 0)//Check if the number is odd
                {
                    sumOfOdds += number;
                }
            }
            
            return sumOfOdds % 2 != 0;//Return true if the sum of odd is odd 
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           if (string.IsNullOrEmpty(password))//Handle null or empty input
               return false;
           
           bool hasUpper = false;//Set flags for each requirement
           bool hasLower = false;
           bool hasDigit = false;

           foreach (char c in password)//Loop through each character in the password
           {
               if  (char.IsUpper(c)) hasUpper = true;
               else if (char.IsLower(c)) hasLower = true;
               else if (char.IsDigit(c)) hasDigit = true;
               
               if  (hasUpper && hasLower && hasDigit)//If all conditions are met, return true early 
                   return true;
           }
           return false;//Return false if not all conditions were met 
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))//Check if the input string is null or empty to avoid an error
            {
                throw new ArgumentException("Input string cannot be null or empty");
            }
            return val[0];//Return the first character 
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))//Check if the string is null or empty to avoid errors
            {
                throw new ArgumentException("Input string cannot be null or empty");
            }
            return val[val.Length - 1];//Return the last character using Length -1
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)//Check for division by zero
            {
                return 0;
            }
            return dividend / divisor;//Perform the division 
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length < 2)//Check for valid input (must have at least 2 elements)
            {
                throw new ArgumentException("Input array must have at least 2 elements");
            }
            return nums[nums.Length - 1] - nums[0];//Subtract the first element from the last
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();//Create a list to store odd numbers
            //Loop from 1 to 99 (inclusive)
            for (int i = 1; i < 100; i += 2)//Increment by 2 to get only odds
            {
                odds.Add(i);
            }
            return odds.ToArray();//Convert the list to an array and return it 
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null) return; //Check if the array is empty or null (nothing to do)

            for (int i = 0; i < words.Length; i++)//Loop through every word in the array
            {
                words[i] = words[i].ToUpper();//Change the word to uppercase and put it back in the array
            }
        }
    }
}
