using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo4
    {
        static void Main()
        {
            int[][] ja=new int[3][];
            ja[0] = new int[4] { 12, 22, 33, 44 };
            ja[1] = new int[3] { 12, 26, 39 };
            ja[2] = new int[5] { 12, 22, 38, 45,76 };
            int m = ja[0][0]; //12
            for(int i = 0; i < 3; i++)
            {
                foreach(int k in ja[i])
                {
                    Console.Write(k+"\t");
                }
                Console.WriteLine();
            }
            int[,][] twodjagged = new int[1, 1][];
            twodjagged[0, 0] = new int[2] { 2, 3 };
            twodjagged[0, 1] = new int[2] { 4, 5 };
        }
    }
}
