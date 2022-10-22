using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class Matrix
    {
        public void addition()
        {
            int[,] m1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] m2 = new int[2, 3] { { 7, 8, 9 }, { 10, 11, 12 } };
            int[,] m3 = new int[2, 3];

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    m3[i, j] = m1[i, j] + m2[i, j];
                }
            }

            Console.WriteLine("Sum of Arrays:");
            for (int k = 0; k < m3.GetLength(0); k++)
            {
                for (int l = 0; l < m3.GetLength(1); l++)
                {
                    Console.Write("{0} ", m3[k, l]);
                }
                Console.Write("\n");
            }
        }
             
    }
}
