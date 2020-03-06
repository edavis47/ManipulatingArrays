using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A___Manipulating_Arrays
{
    class SortingArrays
    {
        //Sorting arrays
        //Write a method that takes an unsorted integer array and prints a sorted array.Use Array C as your test array.
        //Do you recognize this list of numbers?

        //HINT: How do you sort a deck of cards? The simplest strategy is to go through the deck and if the “next” card 
        //is “smaller” than the current card, swap them. Then, repeat the process until all cards are in order.You should 
        //try to implement this without any outside help, but if you need just a hint, check out bubble sort.

        //You will find that recruiters and hiring managers like to give these kinds of whiteboarding problems. 
        //You will probably see these or similar when you interview at Microsoft.
        public static string Sort(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        int temp = x[j];
                        x[j] = x[i];
                        x[i] = temp;
                    }
                }
            }

            //Return array in a string
            string output = string.Empty;
            for (int item = 0; item < x.Length; item++)
            {
                if (item == 0)
                {
                    output += x[item].ToString();
                }
                else
                {
                    output += ", " + x[item].ToString();
                }
            }
            return output;
        }
    }
}
