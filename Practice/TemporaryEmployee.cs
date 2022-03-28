using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class TemporaryEmployee : Employee
    {
        public override string PrintFullName()
        {
            return ($"Su nombre completo es {name} {lastName} temporaryemployee");
        }

    }
}
