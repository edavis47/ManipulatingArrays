using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A___Manipulating_Arrays
{
    class Menu
    {
        //private static int[] A = { 0, 2, 4, 6, 8, 10 };
        //private static int[] B = { 1, 3, 5, 7, 9 };
        //private static int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
        public static string PrintMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.Append("\n MANIPULATING ARRAYS:");
            menu.Append("\n Enter a menu item");
            menu.Append("\n 1 : Mean of array values");
            menu.Append("\n 2 : Reversing arrays");
            menu.Append("\n 3 : Rotating arrays");
            menu.Append("\n 4 : Sorting arrays");
            menu.Append("\n~~~~~~~~~~~~~~~~~~~~~~~~~");
            menu.Append("\n 0 : exit\n");
            return menu.ToString();
        }
        public static string MenuSwitch(string input)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            string output = string.Empty;
            switch (input)
            {
                case "1": // mean of arrays
                        output = $"Mean of Array A : {MeanOfArrays.MeanArray(A)}" +
                            $"\nMean of Array B : {MeanOfArrays.MeanArray(B)}" +
                            $"\nMean of Array C : {MeanOfArrays.MeanArray(C)}";
                        break;
                case "2": //reversing arrays
                        output = $"Reversed Array A : {ReverseArrays.ReverseArray(A)}" +
                            $"\nReversed Array B : {ReverseArrays.ReverseArray(B)}" +
                            $"\nReversed Array C : {ReverseArrays.ReverseArray(C)}"; ;
                        break;
                case "3": //rotating arrays
                        Console.WriteLine(RotateMenu());
                        switch (Console.ReadLine())
                        {
                            case "1"://Array A
                                RotateSwitch(A);
                                break;
                            case "2"://Array B
                                RotateSwitch(B);
                                break;
                            case "3"://Array C
                                RotateSwitch(C);
                                break;
                            default:
                                output = "Enter a valid option";
                                Console.ReadLine();
                                Console.Clear();
                                MenuSwitch("3");
                                break;
                        }
                        //output = ?
                        break;
                case "4": // sorting arrays
                        output = $"Array A sorted : {SortingArrays.Sort(A)}" +
                            $"\nArray B sorted : {SortingArrays.Sort(B)}" +
                            $"\nArray C sorted : {SortingArrays.Sort(C)}"; ;
                        break;
                case "0":
                        Environment.Exit(0);
                        break;
                default:
                        output = "Enter a valid option";
                        break;
            }
            return output;
        }
        public static string RotateMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.Append("\n ROTATE AN ARRAY");
            menu.Append("\n Select an array to rotate");
            menu.Append("\n 1 : Array A");
            menu.Append("\n 2 : Array B");
            menu.Append("\n 3 : Array C");
            menu.Append("\n~~~~~~~~~~~~~~~~~~~~~~~~~");
            return menu.ToString();
        }
        public static void RotateSwitch(int[] array)
        {
            Console.WriteLine(" What direction would you like to rotate?\n \"R\" For rotating to the right." +
            "\n \"L\" For rotating to the left.");
            
            switch (Console.ReadLine().ToUpper())
            {
                case "L": //Left rotation
                    RotateNumPlaces(array, 'L');
                    break;
                case "R": //Right rotation
                    RotateNumPlaces(array, 'R');
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    Console.ReadLine();
                    Console.Clear();
                    MenuSwitch("3");
                    break;
            }
            //string output; return output;
        }
        public static void RotateNumPlaces(int[] x, char dir)
        {
            try
            {
                Console.WriteLine($" Enter a positive interger value for how many places that you would like to rotate\n between 0 - {x.Length - 1}");
                Int32.TryParse(Console.ReadLine(), out int a);
                if (a > x.Length)
                {
                    Console.WriteLine("Enter a length that fits the prompt range.");
                    RotateNumPlaces(x, dir);
                }
                RotatingArrays.Rotate(x, dir, a);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
