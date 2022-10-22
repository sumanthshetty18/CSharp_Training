using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Training
{
    internal class Files2
    {
        public void read()
        {
            string[] content;
            string path = @"C:\Users\EI13149\source\repos\CSharp_Training\CSharp_Training\Tables.txt";
            content = File.ReadAllLines(path);
            var count =  File.ReadAllLines(path).Length;
            Console.WriteLine(content[0]);
            Console.WriteLine($"Number of Lines in the file: {count}");

        }
        public void copy()
        {
            string path = @"C:\Users\EI13149\source\repos\CSharp_Training\CSharp_Training\Tables.txt";
            string path1 = @"C:\Users\EI13149\source\repos\CSharp_Training\CSharp_Basics\New.txt";
            File.Copy(path, path1);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("File has been copied");
        }
        public void move()
        {
            string path2 = @"C:\Users\EI13149\source\repos\CSharp_Training\CSharp_Basics\New.txt";
            string path3 = @"C:\Users\EI13149\source\repos\CSharp_Training\CSharp_Training\Tables2.txt";
            File.Copy(path2, path3);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("File has been moved");
        }
        public void delete()
        {
            string path4 = @"C:\Users\EI13149\source\repos\CSharp_Training\CSharp_Training\Tables2.txt";
            File.Delete(path4);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("File has been deleted");
            Console.WriteLine("-----------------------------------------");
        }
    }
}
