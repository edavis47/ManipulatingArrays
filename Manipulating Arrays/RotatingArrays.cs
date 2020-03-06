using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A___Manipulating_Arrays
{
    class RotatingArrays
    {
        //Rotating arrays
        //Arrays can be rotated to the right or to the left by any number of places.Rotating an array to the right by 
        //two places puts the first element in position three, the second element in position four, and so on, with the 
        //last element in position two and the next to last element in position one. Array A rotated to the right by two 
        //places results in [8, 10, 0, 2, 4, 6]. Likewise, rotating an array to the left places the first elements at the 
        //end.Array B rotated to the left by two places results in [5, 7, 9, 1, 3].

        //Write a method that accepts three parameters, a direction (right or left), a number of places, and an array, 
        //which prints the appropriate rotation.Call the method on all three arrays. Rotate array A two places to the 
        //left. Rotate array B two places to the right. Rotate array C four places to the left.
        public static void Rotate(int[] array, char direction, int numPlaces)
        
        {
            direction = Char.ToUpper(direction);
            int[] replacement = new int[array.Length]; // THIS NEW ARRAY WILL RECIEVE ALL THE INPUT ARRAY'S VALUES IN THE NEW ORDER

            
            if (direction == 'R')   // ROTATE RIGHT
            {// len 5 { 1, 3, 5, 7, 9 } R, 4 = 3, 5, 7, 9, 7 ????????
                for (int i = 0; i < array.Length; i++)
                {   //[0, 1, 2, 3, 4, 5]  -->  [4, 5, 0, 1, 2, 3] (right two spaces) A = { 0, 2, 4, 6, 8, 10 };
                    if (i < numPlaces)
                    {   //insert largest indecies in array into smallest in replacement until numPlaces limit reached
                        replacement[i] = array[array.Length - (numPlaces - i)];
                    }
                    else if (i >= numPlaces)
                    {   //insert smallest indecies in array into replacement indecies beginning after the (filled) numPlaces values
                        replacement[i] = array[i - numPlaces];
                        //i needs to be involved in the array[] space so that it will increment through that array as well
                    }
                }
            }
            if (direction == 'L')   // ROTATE LEFT
            {
                for (int i = 0; i < array.Length ; i++)
                {   //[0, 1, 2, 3, 4, 5]  -->  [2, 3, 4, 5, 0, 1] (left two spaces)
                    if (i < array.Length - numPlaces)
                    {
                        replacement[i] = array[numPlaces + i];
                    }
                    else if (i >= array.Length - numPlaces)
                    {
                        replacement[i] = array[-array.Length + (numPlaces + i)];
                        //spot 4 needs array spot 0 and 5 needs aray spot 1
                    }
                }
            }
            //PRINT ANSWER TO SCREEN

            Console.WriteLine($"\n Direction: {direction}\n Number of spaces: {numPlaces}\n");
            Console.WriteLine($" Original: {string.Join(", ", array)}");
            Console.Write($"  Rotated: {string.Join(", ", replacement)}");
        }
    }
}