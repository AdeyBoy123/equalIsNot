using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace equalIsNot
{
    internal class Program
    {
        public static bool EqualIsNot(string str)
        {
            int countIs = CountOccurrences(str, "is");
            int countNot = CountOccurrences(str, "not");

            return countIs == countNot;
        }

        public static int CountOccurrences(string source, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = source.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(EqualIsNot("This is not"));   // false
            Console.ReadLine();
            Console.WriteLine(EqualIsNot("This is notnot"));    // true
            Console.ReadLine();
            Console.WriteLine(EqualIsNot("noisxxnotyynotxisi"));    // true
            Console.ReadLine();
        }
    }
}
