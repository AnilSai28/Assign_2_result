using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the employee name :");
            string employeename = Console.ReadLine();

            Console.WriteLine("enter the monthly salary :");
            double monthlysalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the type of employee");
            string employeetype = Console.ReadLine();

            employee obj = null;
            if (employeetype == "normal")
            {
                obj = new employee(employeename, monthlysalary);
            }
            else if (employeetype == "contract")
            {
                obj = new employee_contract(employeename, monthlysalary);
            }
            else if (employeetype=="fresher")
            {
                obj = new fresher(employeename, monthlysalary);
            }
            if (obj != null)
            {
                Console.WriteLine(obj.pemployeeid);
                Console.WriteLine(obj.pemployeename);
                Console.WriteLine(obj.pmonthlysalary);

                string details = obj.getdetails();
                Console.WriteLine(details);
                string work = obj.getwork();
                Console.WriteLine(work);

                Console.WriteLine("enter no of days : ");
                int days = Convert.ToInt32(Console.ReadLine());

                double salary = obj.getsalary(days);
                Console.WriteLine("salary : " + salary);
            }
            Console.ReadLine();
        }
    }
}
