using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppday3
{
    internal class Testemp
    {
        public static void Main()
        {
            emp ceo = new emp(22854, "shilpa", "RCR",451, 741764567, 70000,7500);
            float NET = ceo.GetNetSalary();
            string GRADE = ceo.GetGrade();
            Console.WriteLine($" Net Salary = {NET}, Grade = {GRADE}");

        }
    }
}
