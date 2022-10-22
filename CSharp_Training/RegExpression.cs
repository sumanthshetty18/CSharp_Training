using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharp_Training
{
    internal class RegExpression
    {
        public void mobile()
        {
            Console.WriteLine("Enter Mobile Number:");
            string mobile=  Console.ReadLine();

            var validate_mobile = Regex.IsMatch(mobile, @"^[789]\d{9}$");
            if (validate_mobile)
                Console.WriteLine("Valid Mobile Number.");
            else
                Console.WriteLine("Invalid Mobile Number.");
        }
    }
}
