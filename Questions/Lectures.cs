using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Questions
{
    internal class Lectures
    {

        static void MainFake()
        {
            // How to use OUT keyword
            // WHEN TO USE ? The out parameters can be used when you want to return more than one values from the method.
            int data1; // initialize edilmeyebilir

            DegistirOut(out data1);

            Console.WriteLine(data1);


            // How to use REF keyword
            // ref is two-ways, out is out-only.
            int data2 = 10; // initialize zorunlu

            DegistirRef(ref data2);

            Console.WriteLine(data2);

        }

        public static void DegistirOut(out int x)
        {
            x = 5;
        }

        public static void DegistirRef(ref int x)
        {
            x = x + 5;
        }


    }
}
