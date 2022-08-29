using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppday3
{
    internal class Testemployee
    {
        public static void Main()
        {
            employee e = new employee(5050, "Shilpa", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Years of experience{e.GetYearsofExp()}");
        }
    }
}
