using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{


    public class Classmain1
    {
        public static Student Student { get; private set; }

        public static void Main()
        {
            ScienceStudent Student = new ScienceStudent { regno = 10, Name = "shilpa" };
            ScienceStudent sciencesubject = new ScienceStudent { physics = 75, chemistry = 65, maths = 45 };
            CommerceStudent Commercessubject = new CommerceStudent { economices = 74, accounts = 85, banking = 75 };

            Console.WriteLine(sciencesubject.GetAvgMarks());
            Console.WriteLine(Commercessubject.GetAvgMarks());
        }
    }
}



