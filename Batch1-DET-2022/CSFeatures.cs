using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hai {name}"); };
            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hai {s1}, " + $"you said {s2}"); };
            action.Invoke("shilpa");
            action1.Invoke("shilpa", "am in bglr");

            Action<int, string, string> printEmp = (int id, string name, string email) =>
            {
                Console.WriteLine($"id={id}, name={name}, email={email}");
            };
            printEmp.Invoke(5050, "shilpa", "shilpa.com");
        }
    }
}

   