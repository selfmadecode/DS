using System;
using System.Collections.Generic;
using System.Text;

namespace ALGOnDS.DS
{
    class TwoDArraysSearch
    {
        private int[,] towDArray = new int [6, 3]
        {
            {110, 44, 51 },
            {7, 6, 8 },
            { 0, 89, 100},
            { 12, 748, 60},
            { 11, 443, 4},
            { 17, 56, 213}
        }; // 6 rows and 3 colums, can also be initialized without the size and rows ( = {{4, 6},{5, 8}})

        public int FindMaxNumberInTwoDArray(int[,] numbers)
        {
            var maxVal = 0;

            for(int row = 0; row < numbers.GetLength(0); row++) // numbers.GetLength(0) - gives the number of rows in a 2D array
            {
                for(int col = 0;  col < numbers.GetLength(1);   col++) //numbers.GetLength(1) - gives the number of elements in the row
                {
                    int singleColumnValue = numbers[row, col]; // stores the current value 

                    if (singleColumnValue > maxVal)
                    {
                        maxVal = singleColumnValue; // assigns the value of the columns to maxVal
                    }
                }
            }

            return maxVal;
        }
    }
}
