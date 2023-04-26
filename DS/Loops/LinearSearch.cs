using System;
using System.Collections.Generic;
using System.Text;

namespace ALGOnDS.DS
{
    public class LinearSearch
    {
        // O(1)
        // The Runtime complexity of this method is 0(1) because it
        // runs in constant time
        public void PrintFirstItem(int[] numbers)  // O(1)
        {            
            Console.WriteLine(numbers[0]); 
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[0]);
        }

        // The runtime complexity of this method is O(n)
        // The cost of looping through the items grows linearly as the size of the item increases
        public void PrintAllItems(int[] numbers) // O(n)
        {
            Console.WriteLine(numbers[0]); // O(1)

            for(int i = 0; i <= numbers.Length; i++) // O(n)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(numbers[0]); // O(1)

            // The bigO is calculated as
            // O(1 + n + 1) => O(2 + n)
            // With bigO, we drop the constant (2) because it does not matter at this point
            // O(n)

            //foreach(int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
        }

        /// <summary>
        /// Loop through an array and return the index of the item if found
        /// The best case scenerio for this is O(1) i.e when the item is at the first index
        /// and the worst case is O(n) the item is not found in the array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public int FindItemIndex(int[] arr, int item)
        {
            for(int index =0; index <= arr.Length; index++)
            {
                if (arr[index] == item)
                    return index;
            }

            return -1;
        }

        public bool WordContainsCharacter(string word, char character)
        {
            foreach(char ch in word)
            {
                return ch == character;
            }


            for(int i =0; i <= word.Length; i++)
            {
                return word[i] == character;
            }

            return false;
        }

        public bool FindBetween(int[] arr, int num, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                return arr[i] == num;
            }

            return false;
        }

    }
}
