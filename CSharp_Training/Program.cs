using CSharp_Basics;
using System;

namespace CSharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            // AccessSpecifier a1 = new AccessSpecifier();
            //a1.display();
            // a1.display2();


            //Files1 file1 = new Files1();
            //file.write();
            //file.read();

            Files2 file2 = new Files2();
            file2.read();
            file2.copy();
            file2.move();
            file2.delete();

            Console.ReadLine();

        }
    }
}
