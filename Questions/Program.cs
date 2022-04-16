using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GiveMeSomething("caglayan"));

            Console.ReadLine();
        }


        /// <summary>
        /// Question_1: Write a function that returns the string "something" joined with a space " " and the given argument a.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string GiveMeSomething(string a)
        {
            return "something" + " " + a;
        }

        /// <summary>
        /// Question_2: Write a function that takes the base and height of a triangle and return its area.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public static int triArea(int b, int h)
        {
            return b * h / 2;
        }

        /// <summary>
        /// Question_3: Write a function that takes an integer minutes and converts it to seconds.
        /// </summary>
        public static int Convert(int minutes) 
        { 
            return minutes * 60;
        }




    }
}
