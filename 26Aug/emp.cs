using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppday3
{
    internal class emp
    {
        int Id;
        string Name;
        string Address;
        int Pin;
        int Phone;
        float GSalary;
        float pf;
        public emp(int Id, string Name, string Address, int Pin, int Phone, float GSalary, float pf)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Pin = Pin;
            this.Phone = Phone;
            this.GSalary = GSalary;
            this.pf = pf;
        }
        public float GetNetSalary()
        {
           return (GSalary - pf);
            }
    public string GetGrade()
    {
        float net = GetNetSalary();
        if(net > 10000)
        {
            return "A";
}
        else if (net > 5000 && net < 10000)
        {
            return "B";
        }
        else
            return "C";
}

}
 }       
       

        
        
           
            
           
        
         
    

