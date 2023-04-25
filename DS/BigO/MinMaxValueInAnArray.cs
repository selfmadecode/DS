using System;
using System.Collections.Generic;
using System.Text;

namespace ALGOnDS.DS.BigO
{
    public class MinMaxValueInAnArray
    {
        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        /// <summary>
        /// Loop through the array and find the min value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindMinValue(int[] arr)
        {
            if(arr.Length < 0)
            {
                return int.MinValue;
            }

            MinValue = arr[0]; // Assign the first element to be the min value

            // if the element at index i is less that the Minimum value, replace the value
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] < MinValue)
                    MinValue = arr[i];
            }

            return MinValue;
        }

        /// <summary>
        /// Loop through an array and find the max value
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindMaxValue(int[] arr)
        {
            if (arr.Length < 0)
                return int.MaxValue;

            MaxValue = arr[0]; // Assign the first element to be the max value

            // if the element at index i is greater that the Max value, replace the value
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > MaxValue)
                    MaxValue = arr[i];
            }

            return MaxValue;
        }
    }
}
