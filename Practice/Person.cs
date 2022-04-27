using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
   public  class Person: AbstractClass
    {

       public string name { get; set; }
        
        public override void  Print(string name)
        {
            Console.WriteLine($"Print method{ name}");
        }
    }
}
