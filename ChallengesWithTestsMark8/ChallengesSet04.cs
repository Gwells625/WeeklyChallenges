using System;
using System.Linq;
using System.Collections.Generic;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //initialize a variable to keep track of the final result 
            int result = 0;
            
            //Loop through each number in the input array
            foreach (int number in numbers)
            {
                //Check if the number is even
                if (number % 2 == 0)
                {
                    //If even, add it to the result
                    result += number;
                }
                else
                {
                    //If odd, subtract it from the result
                    result -= number;
                }
            }
            
            //Return the final computed value
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           //Get the length of each input string
           int len1 = str1.Length;
           int len2 = str2.Length;
           int len3 = str3.Length;
           int len4 = str4.Length;
           
           //Use Math.Min to find the shortest length among the four 
           //Compare in pairs: first find min of two, then compare result with the third 
           int shortest = Math.Min(Math.Min(len1, len2), Math.Min(len3,  len4));
           
           //Return the length of the shortest string
           return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
           //Use Math.Min to compare the first two numbers
           int min1 = Math.Min (number1, number2);
           
           //Use Math.Min to compare the next two numbers
           int min2 = Math.Min (number3, number4);
           
           //Compare the two minimums to find the overall smallest number
           int smallest = Math.Min (min1, min2);
           
           //Return the smallest number
           return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
          //A triangle is valid if the sum of any two sides is greater than the third side.
          //Check all three conditions to verify if the given sides can form a triangle.
          
          //Check if sideLength1 + sideLength2 is greater than sideLength3
          bool cond1 = sideLength1 + sideLength2 > sideLength3;
          
          //Check if sideLength1 + sideLength3 is greater than sideLength2
          bool cond2 = sideLength1 + sideLength3 > sideLength2;
          
          //Check if sideLength2 + sideLength3 is greater than sideLength1
          bool cond3 = sideLength2 + sideLength3 > sideLength1;
          
          //Return true only if all three conditions are true, otherwise false
          return cond1 && cond2 && cond3;
        }

        public bool IsStringANumber(string input)
        {
           //The TryParse method attempts to convert the string to a double
           //It returns true if the conversion was successful, otherwise false.
           //This is a safe way to check if the input string is a valid number
          
           //Variable to store the parsed number
           double number;
           bool isNumber = double.TryParse(input, out number);
           
           //Return the result of TryParse:
           //true if input is a valid number, false otherwise
           return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //Count how many elements in the array null
            int nullCount = 0;
            
            //Loop through each element in the array
            foreach (var obj in objs)
            {
                //If the current element is null, increment the couter
                if (obj == null)
                {
                    nullCount++;
                }
            }
            
            //Calculate if the count of null elements is more than half the length of the array
            //If yes, return true, otherwise false
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
           //Check if the input array is null or has no elements
           if (numbers == null || numbers.Length == 0)
           {
               //Return 0 because there's nothing to average
               return 0;
           }
           
           //Create a list to store even numbers
           var evens = new List<int>();
           
           //Loop through each number in the array
           foreach (int num in numbers)
           {
               //Check if the number is even
               if (num % 2 == 0)
               {
                   //Add even number to the list
                   evens.Add(num);
               }
           }
           
           //If no even numbers were found, return 0
           if (evens.Count == 0)
           {
               return 0;
           }
           
           //Calculate the average of the even numbers and return it
           return evens.Average();
        }

        public int Factorial(int number)
        {
           //Factorial is only defined for non-negative integers
           //If the input is less then 0, you could throw an exception or return 1.
           if (number < 0)
           {
               throw new ArgumentOutOfRangeException("Factorial is not defined for  negative numbers");
           }
           
           //The factorial of 0 is 1 by definition (0! = 1)
           if (number == 0)
           {
               return 1;
           }
           
           //Initialize the result to 1
           int result = 1;
           
           //Loop from 1 up to the input number
           for (int i = 1; i <= number; i++)
           {
               //Multiply result by the current number
               result *= i;
           }
           
           //Return the final factorial value
           return result;
        }
    }
}
