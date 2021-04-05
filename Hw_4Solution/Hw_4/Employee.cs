using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public abstract class Employee
    {
        public abstract float Method(float Salary);
    }

    public class Child : Employee
    {
        public override float Method(float Salary)
            => Salary * 12;
    }
}
