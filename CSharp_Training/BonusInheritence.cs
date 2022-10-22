using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training
{
    public class BonusInheritence
    {
        protected int id;
        protected void Bonus()
        {
            Console.WriteLine("Bonus Generating...");
        }
    }
    public class Staff : BonusInheritence
    {
        int bonus;
        public void calculate_bonus(int salary)
        {
            Bonus();
            bonus = salary * 3;
            Console.WriteLine("Bonus For Staff:{0}",bonus);
        }
    }

    public class NonStaff : BonusInheritence
    {
        int bonus;
        public void calculate_bonus(int salary)
        {
            Bonus();
            bonus = salary * 2;
            Console.WriteLine("Bonus For Staff:{0}", bonus);
        }
    }
}
