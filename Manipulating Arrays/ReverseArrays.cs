using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A___Manipulating_Arrays
{
    class ReverseArrays
    {
        //Reversing arrays
        //Write a method that accepts an array as an argument and prints the reversed array.For example, if you
        //pass the method Array B, it should print[9, 7, 5, 3, 1]. Print the reverse of all three arrays.

        public static string ReverseArray(int[] x)
        {
            string output = string.Empty;
            for (int i = 0; i < x.Length / 2; i++)
            {
                int temp = x[i];
                x[i] = x[x.Length - i - 1];
                x[x.Length - i - 1] = temp;
            }

            //Return array in a string
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
