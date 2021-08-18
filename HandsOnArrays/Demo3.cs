using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo3
    {
        static void Main()
        {
            // 2 Dimensional array
            int[,] twod = new int[3, 2];
            //assign values to arrray
            //1st row
            twod[0, 0] = 10;
            twod[0, 1] = 20;
            //2nd row
            twod[1, 0] = 30;
            twod[1, 1] = 40;
            //3rd row
            twod[2, 0] = 50;
            twod[2, 1] = 60;

            //access value
            int k = twod[1, 1]; //40
            foreach(int i in twod)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //display elements in matrix format
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(twod[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
