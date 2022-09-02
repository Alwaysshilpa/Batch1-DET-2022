using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Groupby
    {
        public static void Main()
        {
            String_Groupby();
        }
        private static void String_Groupby()
        {
            List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "grapes", "banana", "cheeze" };
            var wordsGroups = words.GroupBy(x => x[0]).Select
        (y => new { FirstLetter = y.Key, words = y });
            foreach (var item in wordsGroups)
            {
                Console.WriteLine("Words that start with the" +
                    "letter '{0}':",
                    item.FirstLetter);
                foreach (var w in item.words)
                {
                    Console.WriteLine(w);
                }
            }
        }
    }
}
            
        
    

