using System;

namespace CSharp_Basics
{
    public class AccessSpecifier
    {
        string name = "Sumanth";
        int id = 13149;

        public void display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("ID  : {0}", id);  
        }
        internal void display2()
        {
            Console.WriteLine("Hello");
        }

    }
}
