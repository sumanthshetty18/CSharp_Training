using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    internal class Files1
    {
        public int sum = 0;
         
        public void write()
        {
            
            using (StreamWriter sw = File.CreateText(@"C:\Users\EI13149\source\repos\CSharp_Training\CSharp_Training\Tables.txt"))
            {
                for (int i = 1; i <= 10; i++)
                {
                    for(int j = 1; j <= 10; j++)
                    {
                        sw.WriteLine($"{i} * {j} = {i * j}");
                    }
                    sw.WriteLine("---------------");
                }
            }
        }
         
        public void read()
        {
            using (StreamReader sr = File.OpenText(@"C:\Users\EI13149\source\repos\CSharp_Training\CSharp_Training\Tables.txt"))
            {
                string contents = null;
                while ((contents = sr.ReadLine()) != null)
                {
                    Console.WriteLine(contents);
                }

            }
        }
    }
}
