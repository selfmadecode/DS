using System;
using System.Collections.Generic;
using System.Text;

namespace ALGOnDS.DS.Loops.QuestionsAndAnswers
{
    public class FindTheNumberOfEvenDigitsInAnArray
    {
        // Question
        // Given an array nums of integers, return how many contains an even number of digits

        // inputs: nums = {43, 6, 45, 875, 1234} => 3
        // 43, 45 and 1234 contains even digits

        /*
         * ********** STEPS TO SOLVE ******************
         * Loop through the numbers in the array
         * Convert each number to string and get the lenght
         * if the modulus of the lenght == 0, then the number is even
         */


        public int CountElementWithEvenDigits(int[] nums)
        {
            int count = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (NumberIsEven(nums[i]))
                    count++;
            }

            return count;
        }

        private bool NumberIsEven(int number)
        {
            int lenghtOfNumber = number.ToString().Length; // convert the number to string and return the lenght

            return lenghtOfNumber % 2 == 0; // calculates the modulus and return true or false;
        }
    }
}
