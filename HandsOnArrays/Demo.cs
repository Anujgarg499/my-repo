using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo
    {
        static void Main()
        {
            int[] n = new int[4] { 12, 23, 34, 45 };
            char[] ch = new char[3] { 'a', 'b', 'c' };
            object[] mix = new object[4] { 12, 23, 'a', true };
            double[] prices = new double[4]
                {12.34,
                34.45,
                45.56,
                56.67};
            int[] numbers = { 12, 23, 34, 45 }; //dynamic arrays

            //String array
            string[] flowers = new string[3]
            {
                "Rose",
                "Lilly",
                "Tulips"
            };
            foreach(string s in flowers)
            {
                //Console.WriteLine(s);
                if (s.Length > 4)
                {
                    Console.WriteLine(s+"\t");
                }
            }

            // Taking size of the array from user
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] n1 = new int[size];
        }
    }
}
