using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo1
    {
        static void Main()
        {
            int[] numbers = { 12, 23, 34, 45, 56, 76, 65};
            Console.WriteLine("Count :" + numbers.Length);
            //Sort array
            Array.Sort(numbers);
            //Reverse array
            Array.Reverse(numbers);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            int[] b = new int[4];
            //copy values of array
            Array.Copy(numbers, b, 4);
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }

        }
    }
}
