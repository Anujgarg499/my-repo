using System;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of array
            int[] n = new int[5];
            //assigning values to array
            n[0] = 11;
            n[1] = 12;
            n[2] = 13;
            n[3] = 14;
            n[4] = 15;
            int k = n[2];
            //Console.WriteLine(k);
            //Console.WriteLine(n[1]);
            foreach (int i in n)
            {
                Console.WriteLine(i);
            }
        }
    }
}
