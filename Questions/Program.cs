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
            Console.WriteLine(MonthName(2)); 

            Console.ReadLine();
        }

        #region Very Easy

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

        #endregion


        #region Easy

        /// <summary>
        /// Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. 
        /// For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string MonthName(int num)
        {
            ////1.way
            //Dictionary<int, string> map = new Dictionary<int, string>()
            //{
            //    {1, "January"},
            //    {2, "February"},
            //    {3, "March"},
            //    {4, "April"},
            //    {5, "May"},
            //    {6, "June"},
            //    {7, "July"},
            //    {8, "August"},
            //    {9, "September"},
            //    {10, "October"},
            //    {11, "November"},
            //    {12, "December"},
            //};

            //return map[num];

            //2.way
            string[] months = new string[12]
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December",
            };

            if (num < 13 && num > 0)
            {
                return months[num - 1];
            }
            else
                return "not any month";

        }


        #endregion


        #region Medium

        #endregion


        #region Hard

        #endregion


        #region Very Hard

        #endregion


        #region Expert

        #endregion
    }
}
