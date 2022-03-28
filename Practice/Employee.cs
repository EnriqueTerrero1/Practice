using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Employee
    {

      public  string name { get; set; } 
        public string lastName { get; set; }
        int age { get; set; }
        string email { get; set; }

       /* public Employee(string name , string lastName){
            this.name = name;
            this.lastName = lastName;
        }*/

        public virtual string PrintFullName()
        {
            return ($"Su nombre completo es {name} {lastName}");
        }
    }
}
