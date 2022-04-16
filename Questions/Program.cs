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


        //question1
        public static string GiveMeSomething(string a)
        {
            return "something" + " " + a;
        }



    }
}
