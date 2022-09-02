using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LINQ_assignments
    {
        public static void Main()
        {
            

            string[] names = { "john", "peter", "jacob", "harry", "jackson" };
            var result = from name in names
                         where name.Contains("o")
                         select name;
            foreach (var name in result)
                Console.WriteLine(name);

            
            
        }
    }
}




