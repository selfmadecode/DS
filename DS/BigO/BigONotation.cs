using System;
using System.Collections.Generic;
using System.Text;

namespace ALGOnDS.DS.BigO
{
    public class BigONotation
    {
        // O(1)
        // The Runtime complexity of this method is 0(1) because it
        // runs in constant time

        public void PrintFirstTime(string[] numbers)
        {
            Console.WriteLine(numbers[1]); // O(1)
        }
    }
}
