using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{

    internal class Program
    {

        public static Solutions solutions;

        static void Main(string[] args)
        {
            // Enter solution number here
            Console.Write("Enter the solution number starting from 1:");

            //int solutionNumber = Int32.Parse(Console.ReadLine()); Eger input karakterse exception atar burası. Dolasyısıyla asagıdaki fonksiyonu kullanmak daha mantıklı.

            Int32.TryParse(Console.ReadLine(), out int solutionNumber); // TrtyParse fonksiyonu asla exception atmaz. Out ile null dısında illa bir output döner.


            solutions = (Solutions)solutionNumber;


          


            // Call the test function
            double[] array = { 5, 3, 2, 1, 7 };

            // Show the outputs of the function
            foreach (var item in FindMinMax(array))
            {
                Console.WriteLine(item);
            }
            


            // Stop the program
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

        /// <summary>
        /// Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static double[] FindMinMax(double[] values)
        {

            switch (solutions)
            {
                case Solutions.Solution1:
                {
                        return new double[2] { values.Min(), values.Max() }; // return new[2]{ values.Min(), values.Max() } compiler changes new[] to new double[]
                }

                case Solutions.Solution2:
                {
                    double[] minMaxArray = new double[2];
                    minMaxArray[0] = minMaxArray[1] = values[0];


                    for (int i = 1; i < values.Length; i++)
                    {
                        if (minMaxArray[0] > values[i])
                        {
                            minMaxArray[0] = values[i];
                        }

                        if (minMaxArray[1] < values[i])
                        {
                            minMaxArray[1] = values[i];
                        }
                    }

                    return minMaxArray;

                }
                        
                default: 
                    return null;
            }

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


    enum Solutions
    {
        Solution1 = 1,
        Solution2 = 2,
        Solution3 = 3,
        Solution4 = 4,
        Solution5 = 5
    }


}
