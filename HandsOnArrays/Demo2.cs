using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo2
    {
        static void Main()
        {
            int[] n = new int[3];
            //read array inputs
            for(int i=0; i<n.Length; i++)
            {
                Console.Write("Enter n[{0}] value:", i);
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int i in n)
            {
                Console.WriteLine(i);
            }
        }
    }
}
