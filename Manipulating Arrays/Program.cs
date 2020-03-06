using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6A___Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" A = [ 0, 2, 4, 6, 8, 10 ]\n B = [ 1, 3, 5, 7, 9 ]\n C = [ 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 ]\n - - - - - - - - - - -- - - - - - - - - - -");

            Console.WriteLine(Menu.PrintMenu());
            Console.WriteLine(Menu.MenuSwitch(Console.ReadLine()));
            Console.ReadKey();
            Console.Clear();
            Program.Main(null);
        }
    }
}
