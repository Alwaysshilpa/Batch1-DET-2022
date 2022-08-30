using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    internal class emp
    {
        int id;
        string name;
        string dept;
        double sal;
        public DateOnly doj;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public emp(int id, string name, DateOnly doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public emp()
        {
            id = -1; name = "no name";
        }
        public emp(int id, string name)
        {
            this.id = id; this.name = name;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }
    }
}
