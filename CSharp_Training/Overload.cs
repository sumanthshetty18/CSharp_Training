using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    class Add
    {
        int x, y;
        double m, n;
        string name1, name2;
        public Add(int a, int b)
        {
            x = a;
            y = b;
        }
        public Add(double a, double b)
        {
            m = a;
            n = b;
        }
        public Add(string a, string b)
        {
            name1 = a;
            name2 = b;
        }
        public void display1()
        {
            Console.WriteLine("Sum of 2 Integers:{0}",(x+y));
        }
        public void display2()
        {
            Console.WriteLine("Sum of 2 Floating Point Numbers:{0}", (m + n));
        }
        public void display3()
        {
            Console.WriteLine("FirstName:{0} LastName:{1}", name1,name2);
        }
    }
    internal class Overload
    {
        static void main()
        {
        }
    }
}
