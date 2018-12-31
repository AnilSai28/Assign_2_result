using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Overriding
{
    class employee_contract:employee
    {
        public employee_contract(string employeename,double monthlysalary):base(employeename,monthlysalary)
        {

        }

        public override double getsalary(int days)
        {
            double total = (this.pmonthlysalary / 30) * days;
            return total;
        }
    }
}
