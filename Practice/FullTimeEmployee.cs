using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    public class FullTimeEmployee: Employee
    {
      public   float yearSalary;
        public override string PrintFullName()
        {
            return ($"Su nombre completo es {name} {lastName} fulltime+");
        }
    }
}
