using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A___Manipulating_Arrays
{
    class MeanOfArrays
    {
        //Counting, summing, computing the mean:
        //Write a method counts the number of elements in an integer array, and then sums the elements in an integer 
        //array.It should return the average of the array elements as a double. Using the count and sum, compute and 
        //print the mean of each array.
        public static double MeanArray(int[] input)
        {
            double mean = 0;
            double sum = 0;
            foreach (int item in input)
            {
                sum += item;
                mean = sum / input.Length;
            }
            return mean;
        }
    }
}
