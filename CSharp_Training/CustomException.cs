using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    class InvalidAge : Exception
    {
        public InvalidAge()
        {
            Console.WriteLine("Age below 22 not valid");
        }
    }
    internal class CustomException
    {
        public void validate(int age)
        {
            if (age <= 22)
                throw new InvalidAge();
            else
                Console.WriteLine("Valid Age.");
        }

        /*
         static void Main(String[] args)
        {
            CustomException cs = new CustomException();
            try{
                Console.WriteLine("Enter the age:");
                int age = Convert.ToInt32(Console.ReadLine());
                cs.validate(age);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        */
    }
}
