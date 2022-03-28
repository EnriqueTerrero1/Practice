using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace Practice
{
    public class PartTimeEmployee:Employee
    {
       public float hourlyRate;
        public  string PrintFullName()
        {
            return ($"Su nombre completo es {name} {lastName} -parttime");
        }
        
    }
   
}
